using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iconsiam {
    public partial class TestImageDragDrop : Form {
        public TestImageDragDrop() {
            InitializeComponent();
        }


        private ClassDataBase classDataBase = new ClassDataBase();
        private DataTable dataTableGrid = new DataTable();

        private bool isMouseDown = false;
        private readonly Color colorCircle = Color.RoyalBlue;
        private readonly Color colorCircleCurrent = Color.Gold;
        private readonly int circleSize = 15;

        private readonly int gridCellCircuitId = 0; 
        private readonly int gridCellCircuitName = 2;
        private readonly int gridCellX = 4;
        private readonly int gridCellY = 5;
        private readonly int gridCellDelete = 7;

        private int gridCurrentRow = -1;
        private int gridCurrentCellX { get; set; }
        private int gridCurrentCellY { get; set; }


        List<CirclePoint> listCircles = new List<CirclePoint>();
        Dictionary<Rectangle, CirclePointXY> CirclePoint = new Dictionary<Rectangle, CirclePointXY>();
        Rectangle rect = new Rectangle(125, 125, 50, 50);


        List<Rectangle> listRects = new List<Rectangle>();


        private void TestImageDragDrop_Load(object sender, EventArgs e) {
            setDataTableGrid();
            setImageCircuitLocation(dataTableGrid);
        }

        private void setDataTableGrid() {
            ClassDataBase classDB = new ClassDataBase();
            GRIDVIEW_CIRCLE.DataSource = null;
            GRIDVIEW_CIRCLE.Rows.Clear();
            GRIDVIEW_CIRCLE.Refresh();

            string sql = @" SELECT TB2.* , TB3.control_name ,'Del' AS `Remove`
                            FROM layout_building TB1
                            LEFT JOIN layout_circuit TB2 ON (TB1.layout_building_id = TB2.layout_building_id) 
                            INNER JOIN config_ip TB3 ON (TB2.config_ip_id = TB3.id) 
                            WHERE TB1.layout_building_id = 1 ";

            dataTableGrid = classDB.getDataTable(sql);
            GRIDVIEW_CIRCLE.DataSource = dataTableGrid;
            GRIDVIEW_CIRCLE.Columns[0].Width = 50;
            GRIDVIEW_CIRCLE.Columns[1].Width = 50;
            GRIDVIEW_CIRCLE.Columns[2].Width = 50;
            GRIDVIEW_CIRCLE.Columns[3].Width = 50;
            GRIDVIEW_CIRCLE.Columns[4].Width = 50;
            GRIDVIEW_CIRCLE.Columns[5].Width = 50;
            GRIDVIEW_CIRCLE.Columns[6].Width = 50;
            GRIDVIEW_CIRCLE.Columns[7].Width = 50;


            classDB.closeConnection();
            GRIDVIEW_CIRCLE.ClearSelection(); 

        }


        private void setCircuitColor(Rectangle circleCircuit) {
            using (Graphics gfx = Graphics.FromImage(this.pictureBox1.Image)) {
                SolidBrush brushRed = new SolidBrush(colorCircle);

                gfx.FillEllipse(brushRed, circleCircuit);
                gfx.DrawEllipse(Pens.RoyalBlue, circleCircuit);
                gfx.Dispose();

            }
        }
        private void setCircuitColorCurrent(Rectangle circleCircuit) {
            using (Graphics gfx = Graphics.FromImage(this.pictureBox1.Image)) {
                SolidBrush brushYellow = new SolidBrush(colorCircleCurrent);

                gfx.FillEllipse(brushYellow, circleCircuit);
                gfx.DrawEllipse(Pens.Yellow, circleCircuit);
                gfx.Dispose();

            }
        }

        private void setImageCircuitLocation(DataTable dataTable) {
            pictureBox1.Image = Properties.Resources.Condo_Layout; 
            if (dataTable.Rows.Count > 0) {
                foreach (DataRow dataRow in dataTable.Rows) {
                    Rectangle circleCircuit = new Rectangle();
                    circleCircuit.Location = new Point(Int32.Parse(dataRow["layout_circuit_x"].ToString()), Int32.Parse(dataRow["layout_circuit_y"].ToString()));
                    circleCircuit.Size = new Size(circleSize, circleSize);
                    setCircuitColor(circleCircuit);

                }
            }

        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e) {
            Rectangle circle_bounds = new Rectangle();
            circle_bounds.Location = e.Location;
            circle_bounds.Size = new Size(circleSize, circleSize);
            circle_bounds.X = circle_bounds.X - 5;
            circle_bounds.Y = circle_bounds.Y - 5;
            listRects.Add(circle_bounds);

            CirclePointXY circlePointXY = new CirclePointXY(e.X, e.Y);
            CirclePoint.Add(circle_bounds, circlePointXY);

            using (Graphics gfx = Graphics.FromImage(this.pictureBox1.Image)) {
                SolidBrush brushRed = new SolidBrush(colorCircle);

                gfx.FillEllipse(brushRed, circle_bounds);
                gfx.DrawEllipse(Pens.RoyalBlue, circle_bounds);
                gfx.Dispose();
                //gfx.DrawEllipse(Pens.Red, circle_bounds);
                //MessageBox.Show("X: " + circle_bounds.X + " :: Y:" + circle_bounds.Y);
                this.pictureBox1.Refresh();
                ClassDataBase classDB = new ClassDataBase();

                //layout_circuit
                Dictionary<string, string> fields = new Dictionary<string, string>();

                fields.Add("layout_building_id", "1");
                fields.Add("layout_circuit_name", "11111");
                fields.Add("config_ip_id", "1");
                fields.Add("layout_circuit_x", circle_bounds.Location.X.ToString());
                fields.Add("layout_circuit_y", circle_bounds.Location.Y.ToString());

                classDB.insertData(fields, "layout_circuit");
                classDB.closeConnection();
                setDataTableGrid();

                //GRIDVIEW_CIRCLE.DataSource = dataTableGrid; 
                //GRIDVIEW_CIRCLE.Rows.Add("" , "" , "" ); 
                //GRIDVIEW_CIRCLE.Refresh() ;
                //GRIDVIEW_CIRCLE.Ro
            }

        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) {
            isMouseDown = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) {
            if (isMouseDown == true) {
                isMouseDown = false;
                rect = new Rectangle(e.X, e.Y, 50, 50);
                // var rc = getRectangle();
                //if (rc.Width > 0 && rc.Height > 0) rectangles.Add(rc);

                this.pictureBox1.Invalidate();
            }


            // Graphics gfx = Graphics.FromImage(this.pictureBox1.Image);
            // gfx.FillRectangle(new SolidBrush(Color.RoyalBlue), rect);
            // this.pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
            if (isMouseDown == true) {
                this.pictureBox1.Invalidate();
            }
        }

        private void GRIDVIEW_CIRCLE_CellClick(object sender, DataGridViewCellEventArgs e) {


        }

        private void GRIDVIEW_CIRCLE_SelectionChanged(object sender, EventArgs e) {

            if (GRIDVIEW_CIRCLE.CurrentRow.Index != this.gridCurrentRow) {
                this.gridCurrentRow = GRIDVIEW_CIRCLE.CurrentRow.Index;
                int rowIndex = GRIDVIEW_CIRCLE.CurrentRow.Index;
                int circuitX = Int32.Parse(GRIDVIEW_CIRCLE.Rows[rowIndex].Cells[gridCellX].Value.ToString());
                int circuitY = Int32.Parse(GRIDVIEW_CIRCLE.Rows[rowIndex].Cells[gridCellY].Value.ToString());

                Console.WriteLine(GRIDVIEW_CIRCLE.Rows[rowIndex].Cells[gridCellX].Value + " : " + GRIDVIEW_CIRCLE.Rows[rowIndex].Cells[gridCellY].Value);

                Rectangle circleCircuit = new Rectangle();
                circleCircuit.Location = new Point(circuitX, circuitY);
                circleCircuit.Size = new Size(circleSize, circleSize);
                this.setCircuitColorCurrent(circleCircuit);
                Rectangle circleCircuitCurrent = new Rectangle();
                circleCircuitCurrent.Location = new Point(this.gridCurrentCellX, this.gridCurrentCellY);
                circleCircuitCurrent.Size = new Size(circleSize, circleSize);
                this.setCircuitColor(circleCircuitCurrent);

                this.gridCurrentCellX = circuitX;
                this.gridCurrentCellY = circuitY;

                pictureBox1.Refresh();
            }



        }

        private void GRIDVIEW_CIRCLE_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            //gridCellDelete
            if (e.RowIndex >= 0) {
                if (e.ColumnIndex == gridCellDelete) {
                    GRIDVIEW_CIRCLE.Cursor = Cursors.No;
                }
                else {
                    GRIDVIEW_CIRCLE.Cursor = Cursors.Default;
                }
            }

        }

        private void GRIDVIEW_CIRCLE_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                if (e.ColumnIndex == gridCellDelete) {
                    //MessageBox.Show("คุณต้องการลบ Circuit \"" + GRIDVIEW_CIRCLE.Rows[e.RowIndex].Cells[gridCellCircuitName].Value + "\"");
                    DialogResult dialogResult = MessageBox.Show("คุณต้องการลบ Circuit \"" + GRIDVIEW_CIRCLE.Rows[e.RowIndex].Cells[gridCellCircuitName].Value + "\" ใช่หรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes) {
                        ClassDataBase classDB = new ClassDataBase();
                        classDB.deleteData("layout_circuit", "id="+ GRIDVIEW_CIRCLE.Rows[e.RowIndex].Cells[gridCellCircuitId].Value); 
                        classDB.closeConnection();

                        setDataTableGrid();
                        setImageCircuitLocation(dataTableGrid);
                    }
                }

            }
        }
    }


    /*
    public class CirclePoint {
        Dictionary<Rectangle, CirclePointXY> circleBounds { get; set; }
    }
    public class CirclePointXY {
        public CirclePointXY(int x, int y) {
            this.circleX = x;
            this.circleY = y;
        }
        private int circleX { get; set; }
        private int circleY { get; set; }
    }
    */

}
