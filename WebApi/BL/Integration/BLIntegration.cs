//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Api.Models;
//using Api.Common;
//using System.Net;
//using System.IO;
//using System.Text;
//using Newtonsoft.Json;
//using Api.Common.DataExport;
//using Api.BL.DataExport;
//using Api.DAL.DTO;

//namespace WebApi.BL.Integration
//{
//    public class BLIntegration
//    {
//        private ApplicationDbContext db = new ApplicationDbContext();

//        /// <summary>
//        /// returns integration content 
//        /// </summary>
//        /// <param name="integrationName"></param>
//        ///  <param name="exportType"> category or product</param>
//        /// <returns></returns>
//        public BLResponse<IntegrationModel> GetIntegration(string integrationName, string exportType)
//        {
//            var blResponse = new BLResponse<IntegrationModel>();
//            blResponse.ResponseCode = ResponseCode.Success;

//            ExportType type = GetExportType(exportType);

//            if (type == ExportType.Undefined)
//            {
//                blResponse.ResponseData = null;
//                blResponse.ResponseCode = ResponseCode.Fail;
//                blResponse.ResponseMessage = ResponseMessage.ExportTypeNotFound;
//                return blResponse;
//            }

//            try
//            {
//                Api.DAL.DTO.Integration integration = db.Integrations.Single(p => p.Name == integrationName);

//                var integrationDetail = integration.IntegrationDetails.Single(p => p.ExportType == type);

//                var integrationSettings = integration.IntegrationSettings;

//                WebRequest request = WebRequest.Create(integrationDetail.Url);
//                var webResponse = request.GetResponse();

//                // Get the stream associated with the response.
//                Stream receiveStream = webResponse.GetResponseStream();

//                // Pipes the stream to a higher level stream reader with the required encoding format. 
//                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

//                string webResponseData = readStream.ReadToEnd();

//                blResponse.ResponseData = new IntegrationModel { Content = GetSerializedData(ref webResponseData, type, integrationSettings) };

//                webResponse.Close();
//                readStream.Close();
//            }
//            catch (Exception)
//            {
//                blResponse.ResponseData = null;
//                blResponse.ResponseCode = ResponseCode.Fail;
//                blResponse.ResponseMessage = ResponseMessage.IntegrationNotFound;
//            }

//            return blResponse;
//        }

//        /// <summary>
//        /// returns all integration summaries
//        /// </summary>
//        /// <returns></returns>
//        public BLResponse<List<IntegrationInfoModel>> GetAllIntegrationInfo()
//        {
//            var blResponse = new BLResponse<List<IntegrationInfoModel>>();
//            blResponse.ResponseCode = ResponseCode.Success;

//            try
//            {
//                var integrationsQuery = db.Integrations.Select(p => new IntegrationInfoModel
//                                {
//                                    Name = p.Name,
//                                    Type = p.Type,
//                                    Status = p.Status,
//                                }
//                           );

//                blResponse.ResponseData = integrationsQuery.ToList();
//            }
//            catch (Exception)
//            {
//                blResponse.ResponseData = null;
//                blResponse.ResponseCode = ResponseCode.Fail;
//                blResponse.ResponseMessage = ResponseMessage.IntegrationNotFound;
//            }

//            return blResponse;
//        }


//        /// <summary>
//        /// gets the export type from query string
//        /// </summary>
//        /// <param name="exportType"></param>
//        /// <returns></returns>
//        private ExportType GetExportType(string exportType)
//        {
//            switch (exportType.ToLower())
//            {
//                case ExportTypeText.Category:
//                    return ExportType.Category;
//                case ExportTypeText.Product:
//                    return ExportType.Product;
//                default:
//                    return ExportType.Undefined;
//            }
//        }

//        /// <summary>
//        /// returns serialized xml string
//        /// </summary>
//        /// <param name="data"></param>
//        /// <param name="exportType"></param>
//        /// <returns></returns>
//        private string GetSerializedData(ref string data, ExportType exportType, ICollection<IntegrationSetting> integrationSettings)
//        {
//            string xml = string.Empty;

//            switch (exportType)
//            {
//                case ExportType.Product:
//                    var productRoot = JsonConvert.DeserializeObject<ProductRoot>(data);
//                    var productExporter = new ProductExporter(productRoot, integrationSettings);
//                    xml = productExporter.ExportData();
//                    break;
//                case ExportType.Category:
//                    var categoryRoot = JsonConvert.DeserializeObject<List<Category>>(data);
//                    var categoryExporter = new CategoryExporter(categoryRoot);
//                    xml = categoryExporter.ExportData();
//                    break;
//            }

//            return xml;
//        }
//    }
//}