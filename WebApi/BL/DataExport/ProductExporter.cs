//using Api.Common.DataExport;
//using System.Collections.Generic;
//using System.Linq;
//using Api.BL.Helper;
//using Api.DAL.DTO;
//using Api.Common;

//namespace WebApi.BL.DataExport
//{
//    //public class ProductExporter : IDataExportable
//    {
//        private ProductRoot _productRoot;
//        private ICollection<IntegrationSetting> _integrationSettings;

//        public ProductExporter(ProductRoot productRoot, ICollection<IntegrationSetting> integrationSettings)
//        {
//            _productRoot = productRoot;
//            _integrationSettings = integrationSettings;
//        }

//        public string ExportData()
//        {
//            string xml = string.Empty;

//            var extendedProductList = new List<ExtendedProduct>();

//            foreach (var product in _productRoot.Products)
//            {
//                ExtendedProduct extendedProduct = new ExtendedProduct() { Product = product };

//                string imageUrlPattern = string.Empty;

//                if (_integrationSettings.Any())
//                {
//                    imageUrlPattern = _integrationSettings.Where(p => p.Key == SettingKey.ImagePath).FirstOrDefault().Value;
//                }

//                extendedProduct.SetProductAttributes(_productRoot.ProductAttributes);
//                extendedProduct.SetProductImages(_productRoot.ProductImages, imageUrlPattern);
//                extendedProduct.SetProductOptions(_productRoot.ProductOptions);
//                extendedProduct.SetProductShippingMethods(_productRoot.ProductShippingMethods);

//                extendedProductList.Add(extendedProduct);
//            }

//            return extendedProductList.Serialize();
//        }
//    }
//}