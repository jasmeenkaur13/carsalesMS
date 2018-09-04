﻿/// <summary>
/// 
/// </summary>
namespace DataTransferObjects
{
    /// <summary>
    /// DTO holds the details of the Owner of the car
    /// </summary>
    public class OwnerDTO
    {
        /// <summary>
        /// Unique value representing owner
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the person , if the owner type is private
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Phone number of the person , if the owner type is private
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Email ID of the owner
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// ABN of the dealer , if the owner type is dealer
        /// </summary>
        public string DealerABN { get; set; }
        /// <summary>
        /// Owner Type : Private/Dealer
        /// </summary>
        public string OwnerType { get; set; }
        /// <summary>
        /// Comments added by the customer
        /// </summary>
        public string Comments { get; set; }
    }
}
