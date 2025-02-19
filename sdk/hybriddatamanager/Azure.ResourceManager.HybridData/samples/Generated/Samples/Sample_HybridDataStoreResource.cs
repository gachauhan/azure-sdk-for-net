// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.HybridData;
using Azure.ResourceManager.HybridData.Models;

namespace Azure.ResourceManager.HybridData.Samples
{
    public partial class Sample_HybridDataStoreResource
    {
        // DataStores_GetGET161
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DataStoresGetGET161()
        {
            // Generated from example definition: specification/hybriddatamanager/resource-manager/Microsoft.HybridData/stable/2019-06-01/examples/DataStores_Get-GET-example-161.json
            // this example is just showing the usage of "DataStores_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridDataStoreResource created on azure
            // for more information of creating HybridDataStoreResource, please refer to the document of HybridDataStoreResource
            string subscriptionId = "6e0219f5-327a-4365-904f-05eed4227ad7";
            string resourceGroupName = "ResourceGroupForSDKTest";
            string dataManagerName = "TestAzureSDKOperations";
            string dataStoreName = "TestStorSimpleSource1";
            ResourceIdentifier hybridDataStoreResourceId = HybridDataStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, dataManagerName, dataStoreName);
            HybridDataStoreResource hybridDataStore = client.GetHybridDataStoreResource(hybridDataStoreResourceId);

            // invoke the operation
            HybridDataStoreResource result = await hybridDataStore.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridDataStoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataStores_GetGET162
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DataStoresGetGET162()
        {
            // Generated from example definition: specification/hybriddatamanager/resource-manager/Microsoft.HybridData/stable/2019-06-01/examples/DataStores_Get-GET-example-162.json
            // this example is just showing the usage of "DataStores_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridDataStoreResource created on azure
            // for more information of creating HybridDataStoreResource, please refer to the document of HybridDataStoreResource
            string subscriptionId = "6e0219f5-327a-4365-904f-05eed4227ad7";
            string resourceGroupName = "ResourceGroupForSDKTest";
            string dataManagerName = "TestAzureSDKOperations";
            string dataStoreName = "TestAzureStorage1";
            ResourceIdentifier hybridDataStoreResourceId = HybridDataStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, dataManagerName, dataStoreName);
            HybridDataStoreResource hybridDataStore = client.GetHybridDataStoreResource(hybridDataStoreResourceId);

            // invoke the operation
            HybridDataStoreResource result = await hybridDataStore.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridDataStoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataStores_CreateOrUpdate_DataSinkPUT162
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DataStoresCreateOrUpdateDataSinkPUT162()
        {
            // Generated from example definition: specification/hybriddatamanager/resource-manager/Microsoft.HybridData/stable/2019-06-01/examples/DataStores_CreateOrUpdate_DataSink-PUT-example-162.json
            // this example is just showing the usage of "DataStores_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridDataStoreResource created on azure
            // for more information of creating HybridDataStoreResource, please refer to the document of HybridDataStoreResource
            string subscriptionId = "6e0219f5-327a-4365-904f-05eed4227ad7";
            string resourceGroupName = "ResourceGroupForSDKTest";
            string dataManagerName = "TestAzureSDKOperations";
            string dataStoreName = "TestAzureStorage1";
            ResourceIdentifier hybridDataStoreResourceId = HybridDataStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, dataManagerName, dataStoreName);
            HybridDataStoreResource hybridDataStore = client.GetHybridDataStoreResource(hybridDataStoreResourceId);

            // invoke the operation
            HybridDataStoreData data = new HybridDataStoreData(HybridDataState.Enabled, new ResourceIdentifier("/subscriptions/6e0219f5-327a-4365-904f-05eed4227ad7/resourceGroups/ResourceGroupForSDKTest/providers/Microsoft.HybridData/dataManagers/TestAzureSDKOperations/dataStoreTypes/AzureStorageAccount"))
            {
                RepositoryId = new ResourceIdentifier("/subscriptions/6e0219f5-327a-4365-904f-05eed4227ad7/resourceGroups/ResourceGroupForSDKTest/providers/Microsoft.Storage/storageAccounts/dmsdatasink"),
                ExtendedProperties = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                    ["extendedSaKey"] = null,
                    ["extendedSaName"] = "/subscriptions/6e0219f5-327a-4365-904f-05eed4227ad7/resourceGroups/ResourceGroupForSDKTest/providers/Microsoft.Storage/storageAccounts/dmsdatasink",
                    ["storageAccountNameForQueue"] = "/subscriptions/6e0219f5-327a-4365-904f-05eed4227ad7/resourceGroups/ResourceGroupForSDKTest/providers/Microsoft.Storage/storageAccounts/dmsdatasink"
                }),
                CustomerSecrets =
{
new HybridDataCustomerSecret("StorageAccountAccessKey","Of4H9eF03G8QuxvkZQEbFWv3YdN3U//WugzuqReQekbXXQyg+QSicVKrwSOOKVi1zWMYGbKg7d5/ES2gdz+O5ZEw89bvE4mJD/wQmkIsqhPnbN0gyVK6nZePXVUU1A+UzjLfvhSA6KyUQfzNAZ5/TLt6fo1JyQrKTtkvnkLFyfv1AqBZ+dw8JK3RZi/rEN8HD3R3qsBwUYfyEuGLGiujy2CGrr/1uPiUVMR6QuFWRsjm39eMSHa4maLg4tQ0IY/jIy8rMlx3KjF3CcCbPzAqEq5vXy37wkjZbus771te1gLSrzcpVKIMg4DrmgaoJ02jAu+izBjNgLXAFPSUneQ8yw==:ezMkh4PMhCnjJtYkpTaP0SdblP5VAeRe4glW2PgIzICHw3T8ZyGDoaTrCv4/m5wtcEhWdtxhta+j1MQWlK5MIA+hvf8QjIDIjQv696ov5y+pcFe/upd2ekGOei7FCwB2u7I8WnkAtIKTUkf6eDQBZXm26DjfG1Dlc+Mjjq+AerukEa6WpOyqrD7Qub26Pgmj4AsuBx19X1EAmTZacubkoiNagXM8V+IDanHOhLMvfgQ7rw8oZhWfofxi4m+eJqjOXXaqSyorNK8UEcqP6P9pDP8AN8ulXEx6rZy2B5Oi0vSV+wlRLbUuQslga4ItOGxctW/ZX8uWozt+5A3k4URt6A==",SupportedEncryptionAlgorithm.Rsa1_5),new HybridDataCustomerSecret("StorageAccountAccessKeyForQueue","Of4H9eF03G8QuxvkZQEbFWv3YdN3U//WugzuqReQekbXXQyg+QSicVKrwSOOKVi1zWMYGbKg7d5/ES2gdz+O5ZEw89bvE4mJD/wQmkIsqhPnbN0gyVK6nZePXVUU1A+UzjLfvhSA6KyUQfzNAZ5/TLt6fo1JyQrKTtkvnkLFyfv1AqBZ+dw8JK3RZi/rEN8HD3R3qsBwUYfyEuGLGiujy2CGrr/1uPiUVMR6QuFWRsjm39eMSHa4maLg4tQ0IY/jIy8rMlx3KjF3CcCbPzAqEq5vXy37wkjZbus771te1gLSrzcpVKIMg4DrmgaoJ02jAu+izBjNgLXAFPSUneQ8yw==:ezMkh4PMhCnjJtYkpTaP0SdblP5VAeRe4glW2PgIzICHw3T8ZyGDoaTrCv4/m5wtcEhWdtxhta+j1MQWlK5MIA+hvf8QjIDIjQv696ov5y+pcFe/upd2ekGOei7FCwB2u7I8WnkAtIKTUkf6eDQBZXm26DjfG1Dlc+Mjjq+AerukEa6WpOyqrD7Qub26Pgmj4AsuBx19X1EAmTZacubkoiNagXM8V+IDanHOhLMvfgQ7rw8oZhWfofxi4m+eJqjOXXaqSyorNK8UEcqP6P9pDP8AN8ulXEx6rZy2B5Oi0vSV+wlRLbUuQslga4ItOGxctW/ZX8uWozt+5A3k4URt6A==",SupportedEncryptionAlgorithm.Rsa1_5)
},
            };
            ArmOperation<HybridDataStoreResource> lro = await hybridDataStore.UpdateAsync(WaitUntil.Completed, data);
            HybridDataStoreResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridDataStoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataStores_CreateOrUpdate_DataSourcePUT162
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DataStoresCreateOrUpdateDataSourcePUT162()
        {
            // Generated from example definition: specification/hybriddatamanager/resource-manager/Microsoft.HybridData/stable/2019-06-01/examples/DataStores_CreateOrUpdate_DataSource-PUT-example-162.json
            // this example is just showing the usage of "DataStores_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridDataStoreResource created on azure
            // for more information of creating HybridDataStoreResource, please refer to the document of HybridDataStoreResource
            string subscriptionId = "6e0219f5-327a-4365-904f-05eed4227ad7";
            string resourceGroupName = "ResourceGroupForSDKTest";
            string dataManagerName = "TestAzureSDKOperations";
            string dataStoreName = "TestStorSimpleSource1";
            ResourceIdentifier hybridDataStoreResourceId = HybridDataStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, dataManagerName, dataStoreName);
            HybridDataStoreResource hybridDataStore = client.GetHybridDataStoreResource(hybridDataStoreResourceId);

            // invoke the operation
            HybridDataStoreData data = new HybridDataStoreData(HybridDataState.Enabled, new ResourceIdentifier("/subscriptions/6e0219f5-327a-4365-904f-05eed4227ad7/resourceGroups/ResourceGroupForSDKTest/providers/Microsoft.HybridData/dataManagers/TestAzureSDKOperations/dataStoreTypes/StorSimple8000Series"))
            {
                RepositoryId = new ResourceIdentifier("/subscriptions/c5fc377d-0085-41b9-86b7-cc96dc56d1e9/resourceGroups/ForDMS/providers/Microsoft.StorSimple/managers/BLR8600"),
                ExtendedProperties = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                    ["extendedSaKey"] = null,
                    ["resourceId"] = "/subscriptions/c5fc377d-0085-41b9-86b7-cc96dc56d1e9/resourceGroups/ForDMS/providers/Microsoft.StorSimple/managers/BLR8600"
                }),
                CustomerSecrets =
{
new HybridDataCustomerSecret("ServiceEncryptionKey","EVuEBV40qv23xDRL4NZBuMms4e3So6ikHjrQYRvG9NloqxdgPOg+ZYzpho5lytI4fmv0ANmRIvDiDboRXcUVSjbB9T2gm19fMIuwZa4FK2+LYEgMqKK1GaLkk7xC8f5IeFUXLo6KyBBpaAiayTnWDcHuYEpMiGrV7trDDcbhMRefO3CHecmH3Z7ye8L0RQ/e7WW8GlCKZj3m0BaG7OrJgjai8gyDfMfGAG5rTqEhDVh2hLQ+TjvUjcOFwHvJusqKTENtbJTNQYmL9wZXsnwBvUwxqrGieILNB7V3GD1Ow9OiV0UCDW1e9LnMueukg+l7YJCU9FUhIPh/nSif6p32zw==:jCfio+pDtY3BSPZDpDJ0L6QdXLYMeOmxaFWtYTOZkNqNTgT8Loc/KSQRjtWS5K4N4btbznuSJ/dzg0aZEzlXgKDSuZgMfd4Ch92ZwAC/BkeCmVrTjiKJsoQXO1IICCUf7GHGBbYnnpsNJcEn4vyc9NXyKwOBjeU+I9AyK7PtYiC03RLpTS6xttFCICteBV0uoBHAiV0chZ5VIIUUMjO9u8EhHqRY7NNcGbWdVJeAb6J3vH4E/DHkQj+DXlpjcLvmK/uqBwxfNju30RJhR04Nmz6zcv/zTcvS0uN5hEPQoHLyv84hjnc4omg/gmNjo2cDW64QxA3RTJ5Sl///4xTBkg==",SupportedEncryptionAlgorithm.Rsa1_5)
},
            };
            ArmOperation<HybridDataStoreResource> lro = await hybridDataStore.UpdateAsync(WaitUntil.Completed, data);
            HybridDataStoreResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridDataStoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataStores_Delete_DataSinkDELETE161
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DataStoresDeleteDataSinkDELETE161()
        {
            // Generated from example definition: specification/hybriddatamanager/resource-manager/Microsoft.HybridData/stable/2019-06-01/examples/DataStores_Delete_DataSink-DELETE-example-161.json
            // this example is just showing the usage of "DataStores_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridDataStoreResource created on azure
            // for more information of creating HybridDataStoreResource, please refer to the document of HybridDataStoreResource
            string subscriptionId = "6e0219f5-327a-4365-904f-05eed4227ad7";
            string resourceGroupName = "ResourceGroupForSDKTest";
            string dataManagerName = "TestAzureSDKOperations";
            string dataStoreName = "TestAzureStorage1";
            ResourceIdentifier hybridDataStoreResourceId = HybridDataStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, dataManagerName, dataStoreName);
            HybridDataStoreResource hybridDataStore = client.GetHybridDataStoreResource(hybridDataStoreResourceId);

            // invoke the operation
            await hybridDataStore.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // DataStores_Delete_DataSourceDELETE161
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DataStoresDeleteDataSourceDELETE161()
        {
            // Generated from example definition: specification/hybriddatamanager/resource-manager/Microsoft.HybridData/stable/2019-06-01/examples/DataStores_Delete_DataSource-DELETE-example-161.json
            // this example is just showing the usage of "DataStores_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridDataStoreResource created on azure
            // for more information of creating HybridDataStoreResource, please refer to the document of HybridDataStoreResource
            string subscriptionId = "6e0219f5-327a-4365-904f-05eed4227ad7";
            string resourceGroupName = "ResourceGroupForSDKTest";
            string dataManagerName = "TestAzureSDKOperations";
            string dataStoreName = "TestStorSimpleSource1";
            ResourceIdentifier hybridDataStoreResourceId = HybridDataStoreResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, dataManagerName, dataStoreName);
            HybridDataStoreResource hybridDataStore = client.GetHybridDataStoreResource(hybridDataStoreResourceId);

            // invoke the operation
            await hybridDataStore.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
