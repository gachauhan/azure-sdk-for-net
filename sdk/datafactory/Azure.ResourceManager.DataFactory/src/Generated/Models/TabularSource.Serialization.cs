// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class TabularSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(QueryTimeout))
            {
                writer.WritePropertyName("queryTimeout"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(QueryTimeout);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(QueryTimeout.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AdditionalColumns))
            {
                writer.WritePropertyName("additionalColumns"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AdditionalColumns);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AdditionalColumns.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySourceType);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SourceRetryCount);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SourceRetryCount.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SourceRetryWait);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SourceRetryWait.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MaxConcurrentConnections);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(MaxConcurrentConnections.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DisableMetricsCollection);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DisableMetricsCollection.ToString()).RootElement);
#endif
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static TabularSource DeserializeTabularSource(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonMWSSource": return AmazonMwsSource.DeserializeAmazonMwsSource(element);
                    case "AmazonRdsForSqlServerSource": return AmazonRdsForSqlServerSource.DeserializeAmazonRdsForSqlServerSource(element);
                    case "AmazonRedshiftSource": return AmazonRedshiftSource.DeserializeAmazonRedshiftSource(element);
                    case "AzureMariaDBSource": return AzureMariaDBSource.DeserializeAzureMariaDBSource(element);
                    case "AzureMySqlSource": return AzureMySqlSource.DeserializeAzureMySqlSource(element);
                    case "AzurePostgreSqlSource": return AzurePostgreSqlSource.DeserializeAzurePostgreSqlSource(element);
                    case "AzureSqlSource": return AzureSqlSource.DeserializeAzureSqlSource(element);
                    case "AzureTableSource": return AzureTableSource.DeserializeAzureTableSource(element);
                    case "CassandraSource": return CassandraSource.DeserializeCassandraSource(element);
                    case "ConcurSource": return ConcurSource.DeserializeConcurSource(element);
                    case "CouchbaseSource": return CouchbaseSource.DeserializeCouchbaseSource(element);
                    case "Db2Source": return Db2Source.DeserializeDb2Source(element);
                    case "DrillSource": return DrillSource.DeserializeDrillSource(element);
                    case "DynamicsAXSource": return DynamicsAXSource.DeserializeDynamicsAXSource(element);
                    case "EloquaSource": return EloquaSource.DeserializeEloquaSource(element);
                    case "GoogleAdWordsSource": return GoogleAdWordsSource.DeserializeGoogleAdWordsSource(element);
                    case "GoogleBigQuerySource": return GoogleBigQuerySource.DeserializeGoogleBigQuerySource(element);
                    case "GreenplumSource": return GreenplumSource.DeserializeGreenplumSource(element);
                    case "HBaseSource": return HBaseSource.DeserializeHBaseSource(element);
                    case "HiveSource": return HiveSource.DeserializeHiveSource(element);
                    case "HubspotSource": return HubspotSource.DeserializeHubspotSource(element);
                    case "ImpalaSource": return ImpalaSource.DeserializeImpalaSource(element);
                    case "InformixSource": return InformixSource.DeserializeInformixSource(element);
                    case "JiraSource": return JiraSource.DeserializeJiraSource(element);
                    case "MagentoSource": return MagentoSource.DeserializeMagentoSource(element);
                    case "MariaDBSource": return MariaDBSource.DeserializeMariaDBSource(element);
                    case "MarketoSource": return MarketoSource.DeserializeMarketoSource(element);
                    case "MySqlSource": return MySqlSource.DeserializeMySqlSource(element);
                    case "NetezzaSource": return NetezzaSource.DeserializeNetezzaSource(element);
                    case "OdbcSource": return OdbcSource.DeserializeOdbcSource(element);
                    case "OracleServiceCloudSource": return OracleServiceCloudSource.DeserializeOracleServiceCloudSource(element);
                    case "PaypalSource": return PaypalSource.DeserializePaypalSource(element);
                    case "PhoenixSource": return PhoenixSource.DeserializePhoenixSource(element);
                    case "PostgreSqlSource": return PostgreSqlSource.DeserializePostgreSqlSource(element);
                    case "PrestoSource": return PrestoSource.DeserializePrestoSource(element);
                    case "QuickBooksSource": return QuickBooksSource.DeserializeQuickBooksSource(element);
                    case "ResponsysSource": return ResponsysSource.DeserializeResponsysSource(element);
                    case "SalesforceMarketingCloudSource": return SalesforceMarketingCloudSource.DeserializeSalesforceMarketingCloudSource(element);
                    case "SalesforceSource": return SalesforceSource.DeserializeSalesforceSource(element);
                    case "SapBwSource": return SapBwSource.DeserializeSapBwSource(element);
                    case "SapCloudForCustomerSource": return SapCloudForCustomerSource.DeserializeSapCloudForCustomerSource(element);
                    case "SapEccSource": return SapEccSource.DeserializeSapEccSource(element);
                    case "SapHanaSource": return SapHanaSource.DeserializeSapHanaSource(element);
                    case "SapOdpSource": return SapOdpSource.DeserializeSapOdpSource(element);
                    case "SapOpenHubSource": return SapOpenHubSource.DeserializeSapOpenHubSource(element);
                    case "SapTableSource": return SapTableSource.DeserializeSapTableSource(element);
                    case "ServiceNowSource": return ServiceNowSource.DeserializeServiceNowSource(element);
                    case "ShopifySource": return ShopifySource.DeserializeShopifySource(element);
                    case "SparkSource": return SparkSource.DeserializeSparkSource(element);
                    case "SqlDWSource": return SqlDWSource.DeserializeSqlDWSource(element);
                    case "SqlMISource": return SqlMISource.DeserializeSqlMISource(element);
                    case "SqlServerSource": return SqlServerSource.DeserializeSqlServerSource(element);
                    case "SqlSource": return SqlSource.DeserializeSqlSource(element);
                    case "SquareSource": return SquareSource.DeserializeSquareSource(element);
                    case "SybaseSource": return SybaseSource.DeserializeSybaseSource(element);
                    case "TeradataSource": return TeradataSource.DeserializeTeradataSource(element);
                    case "VerticaSource": return VerticaSource.DeserializeVerticaSource(element);
                    case "XeroSource": return XeroSource.DeserializeXeroSource(element);
                    case "ZohoSource": return ZohoSource.DeserializeZohoSource(element);
                }
            }
            Optional<BinaryData> queryTimeout = default;
            Optional<BinaryData> additionalColumns = default;
            string type = "TabularSource";
            Optional<BinaryData> sourceRetryCount = default;
            Optional<BinaryData> sourceRetryWait = default;
            Optional<BinaryData> maxConcurrentConnections = default;
            Optional<BinaryData> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    queryTimeout = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("additionalColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    additionalColumns = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceRetryCount = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceRetryWait = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableMetricsCollection = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TabularSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, disableMetricsCollection.Value, additionalProperties, queryTimeout.Value, additionalColumns.Value);
        }
    }
}
