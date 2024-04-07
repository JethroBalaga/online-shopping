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
    public class Supplier : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Supplier(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }






       
        string supplier_Address;
        string supplier_Id;
        string supplier_Name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string supplier_name
        {
            get => supplier_Name;
            set => SetPropertyValue(nameof(supplier_name), ref supplier_Name, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string supplier_id
        {
            get => supplier_Id;
            set => SetPropertyValue(nameof(supplier_id), ref supplier_Id, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string supplier_address
        {
            get => supplier_Address;
            set => SetPropertyValue(nameof(supplier_address), ref supplier_Address, value);
        }

        [Association("Supplier-Products")]
        public XPCollection<Product> Products
        {
            get
            {
                return GetCollection<Product>(nameof(Products));
            }
        }

    }
}