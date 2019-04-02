using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iconsiam {
    class ClassBoardRelay {

        public string id { get; set; }
        public string board_relay_name { get; set; }
        public string relay_name_1 { get; set; }
        public string relay_name_2 { get; set; }
        public string relay_name_3 { get; set; }
        public string relay_name_4 { get; set; }
        public string relay_name_5 { get; set; }
        public string relay_name_6 { get; set; }
        public string relay_name_7 { get; set; }
        public string relay_name_8 { get; set; }



        public List<ClassRelayInsert> relayInserts { get; set; }







    }


    class ClassRelayInsert {

        public string group_id { get; set; }
        public string control_name { get; set; }
        public string relay_id { get; set; }
        public string relay_position { get; set; }
        
    }
}
