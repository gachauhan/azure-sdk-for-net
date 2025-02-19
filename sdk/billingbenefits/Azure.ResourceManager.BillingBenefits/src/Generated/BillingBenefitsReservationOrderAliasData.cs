// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.BillingBenefits.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.BillingBenefits
{
    /// <summary> A class representing the BillingBenefitsReservationOrderAlias data model. </summary>
    public partial class BillingBenefitsReservationOrderAliasData : ResourceData
    {
        /// <summary> Initializes a new instance of BillingBenefitsReservationOrderAliasData. </summary>
        /// <param name="sku"> Reservation order SKU. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public BillingBenefitsReservationOrderAliasData(BillingBenefitsSku sku)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Sku = sku;
        }

        /// <summary> Initializes a new instance of BillingBenefitsReservationOrderAliasData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> Reservation order SKU. </param>
        /// <param name="location"> The Azure Region where the reserved resource lives. </param>
        /// <param name="displayName"> Display name. </param>
        /// <param name="reservationOrderId"> Identifier of the reservation order created. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="billingScopeId"> Subscription that will be charged for purchasing the benefit. </param>
        /// <param name="term"> Represent benefit term in ISO 8601 format. </param>
        /// <param name="billingPlan"> Represents the billing plan in ISO 8601 format. Required only for monthly billing plans. </param>
        /// <param name="appliedScopeType"> Type of the Applied Scope. </param>
        /// <param name="appliedScopeProperties"> Properties specific to applied scope type. Not required if not applicable. </param>
        /// <param name="quantity"> Total Quantity of the SKUs purchased in the Reservation. </param>
        /// <param name="isRenewed"> Setting this to true will automatically purchase a new benefit on the expiration date time. </param>
        /// <param name="reservedResourceType"> The type of the resource that is being reserved. </param>
        /// <param name="reviewOn"> This is the date-time when the Reservation needs to be reviewed. </param>
        /// <param name="reservedResourceProperties"> Properties specific to each reserved resource type. Not required if not applicable. </param>
        internal BillingBenefitsReservationOrderAliasData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BillingBenefitsSku sku, AzureLocation? location, string displayName, ResourceIdentifier reservationOrderId, BillingBenefitsProvisioningState? provisioningState, ResourceIdentifier billingScopeId, BillingBenefitsTerm? term, BillingBenefitsBillingPlan? billingPlan, BillingBenefitsAppliedScopeType? appliedScopeType, BillingBenefitsAppliedScopeProperties appliedScopeProperties, int? quantity, bool? isRenewed, BillingBenefitsReservedResourceType? reservedResourceType, DateTimeOffset? reviewOn, ReservationOrderAliasResponsePropertiesReservedResourceProperties reservedResourceProperties) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            Location = location;
            DisplayName = displayName;
            ReservationOrderId = reservationOrderId;
            ProvisioningState = provisioningState;
            BillingScopeId = billingScopeId;
            Term = term;
            BillingPlan = billingPlan;
            AppliedScopeType = appliedScopeType;
            AppliedScopeProperties = appliedScopeProperties;
            Quantity = quantity;
            IsRenewed = isRenewed;
            ReservedResourceType = reservedResourceType;
            ReviewOn = reviewOn;
            ReservedResourceProperties = reservedResourceProperties;
        }

        /// <summary> Reservation order SKU. </summary>
        internal BillingBenefitsSku Sku { get; set; }
        /// <summary> Name of the SKU to be applied. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new BillingBenefitsSku();
                Sku.Name = value;
            }
        }

        /// <summary> The Azure Region where the reserved resource lives. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Identifier of the reservation order created. </summary>
        public ResourceIdentifier ReservationOrderId { get; }
        /// <summary> Provisioning state. </summary>
        public BillingBenefitsProvisioningState? ProvisioningState { get; }
        /// <summary> Subscription that will be charged for purchasing the benefit. </summary>
        public ResourceIdentifier BillingScopeId { get; set; }
        /// <summary> Represent benefit term in ISO 8601 format. </summary>
        public BillingBenefitsTerm? Term { get; set; }
        /// <summary> Represents the billing plan in ISO 8601 format. Required only for monthly billing plans. </summary>
        public BillingBenefitsBillingPlan? BillingPlan { get; set; }
        /// <summary> Type of the Applied Scope. </summary>
        public BillingBenefitsAppliedScopeType? AppliedScopeType { get; set; }
        /// <summary> Properties specific to applied scope type. Not required if not applicable. </summary>
        public BillingBenefitsAppliedScopeProperties AppliedScopeProperties { get; set; }
        /// <summary> Total Quantity of the SKUs purchased in the Reservation. </summary>
        public int? Quantity { get; set; }
        /// <summary> Setting this to true will automatically purchase a new benefit on the expiration date time. </summary>
        public bool? IsRenewed { get; set; }
        /// <summary> The type of the resource that is being reserved. </summary>
        public BillingBenefitsReservedResourceType? ReservedResourceType { get; set; }
        /// <summary> This is the date-time when the Reservation needs to be reviewed. </summary>
        public DateTimeOffset? ReviewOn { get; set; }
        /// <summary> Properties specific to each reserved resource type. Not required if not applicable. </summary>
        internal ReservationOrderAliasResponsePropertiesReservedResourceProperties ReservedResourceProperties { get; set; }
        /// <summary> Turning this on will apply the reservation discount to other VMs in the same VM size group. </summary>
        public BillingBenefitsInstanceFlexibility? ReservedResourceInstanceFlexibility
        {
            get => ReservedResourceProperties is null ? default : ReservedResourceProperties.InstanceFlexibility;
            set
            {
                if (ReservedResourceProperties is null)
                    ReservedResourceProperties = new ReservationOrderAliasResponsePropertiesReservedResourceProperties();
                ReservedResourceProperties.InstanceFlexibility = value;
            }
        }
    }
}
