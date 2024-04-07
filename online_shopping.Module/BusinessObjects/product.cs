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
    public class Product : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Product(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }



        Supplier productSupplier;
        ProductCategory products_Category;
        string product_Quantity;
        string product_Status;
        string product_Name;
        

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]

        public string product_name
        {
            get => product_Name;
            set => SetPropertyValue(nameof(product_name), ref product_Name, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]

        public string product_status
        {
            get => product_Status;
            set => SetPropertyValue(nameof(product_status), ref product_Status, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string product_quantity
        {
            get => product_Quantity;
            set => SetPropertyValue(nameof(product_quantity), ref product_Quantity, value);
        }

        [Association("ProductCategory-Products")]
        public ProductCategory Products_category
        {
            get => products_Category;
            set => SetPropertyValue(nameof(Products_category), ref products_Category, value);


        }
        
        [Association("Supplier-Products")]
        public Supplier ProductSupplier
        {
            get => productSupplier;
            set => SetPropertyValue(nameof(ProductSupplier), ref productSupplier, value);
        }

    }

    }
    
