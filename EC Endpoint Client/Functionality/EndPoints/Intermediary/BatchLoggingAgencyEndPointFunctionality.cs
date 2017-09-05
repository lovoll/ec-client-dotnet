﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.BatchLoggingAgency;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.Intermediary;

namespace EC_Endpoint_Client.Functionality.EndPoints.Intermediary
{
    public class BatchLoggingAgencyEndPointFunctionality : EndPointFunctionalityBase
    {
        private BatchLoggingAgencyExternalECClient GenerateBatchLoggingAgencyProxy(BaseShipment shipment)
        {
            return GenerateProxy<BatchLoggingAgencyExternalECClient, IBatchLoggingAgencyExternalEC>(shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            OperationContext = "BatchLoggingAgencyTest";
            using (var client = GenerateBatchLoggingAgencyProxy(shipment))
            {
                client.Test();
            }
        }

        public BatchLoggingStatusOverview GetStatusOverview(BatchLoggingAgencyShipment shipment)
        {
            OperationContext = "BatchLoggingAgencyGetStatusOverview";
            using (var client = GenerateBatchLoggingAgencyProxy(shipment))
            {
                return client.GetStatusOverview(shipment.Username, shipment.Password, shipment.BatchLoggingRequest);
            }
        }

        public BatchLoggingDetailedStatus GetDetailedOverview(BatchLoggingAgencyShipment shipment)
        {
            OperationContext = "BatchLoggingAgencyGetStatusOverview";
            using (var client = GenerateBatchLoggingAgencyProxy(shipment))
            {
                return client.GetDetailedStatus(shipment.Username, shipment.Password, shipment.BatchLoggingRequest);
            }
        }

        public DataItem GetDataItem(BatchLoggingAgencyShipment shipment)
        {
            OperationContext = "BatchLoggingAgencyGetStatusOverview";
            using (var client = GenerateBatchLoggingAgencyProxy(shipment))
            {
                return client.GetDataItem(shipment.Username, shipment.Password, shipment.DataItemIdRequest.DataItemId);
            }
        }
    }
}
