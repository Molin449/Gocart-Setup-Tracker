using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GocartSetupTracker.Models {
    public class CartSetupPropertyData {

        public string Key { get; set; }
        public string Value { get; set; }
        public PropertyInfo Propinfo { get; set; }


        public CartSetupPropertyData(string key, string value, PropertyInfo propinfo) {
            this.Key = key;
            this.Value = value;
            this.Propinfo = propinfo;
        }
    }
}
