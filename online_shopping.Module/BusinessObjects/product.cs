using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace online_shopping.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class product : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public product(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string quantity;
        string product_Status;
        string product_Price;
        string product_Type;
        string product_Name;
        string product_Id;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string product_id
        {
            get => product_Id;
            set => SetPropertyValue(nameof(product_id), ref product_Id, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string product_name
        {
            get => product_name;
            set => SetPropertyValue(nameof(product_name), ref product_Name, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string product_type
        {
            get => product_Type;
            set => SetPropertyValue(nameof(product_type), ref product_Type, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string product_price
        {
            get => product_Price;
            set => SetPropertyValue(nameof(product_price), ref product_Price, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string product_status
        {
            get => product_Status;
            set => SetPropertyValue(nameof(product_status), ref product_Status, value);
        }
        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string quantity_
        {
            get => quantity;
            set => SetPropertyValue(nameof(quantity_), ref quantity, value);
        }
    }
}