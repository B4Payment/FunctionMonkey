using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Swashbuckle.Customers
{
    /// <summary>
    ///     Parameters of a customer object
    /// </summary>
    [DataContract(Name = "Customer")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CustomerDto
    {
        /// <summary>
        ///     The unique identifier of this customer object.
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     Fixed timestamp, recording when this customer object was created
        /// </summary>
        [DataMember(Name = "createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     One of:
        ///     * created - The customer is created and its id can be immediately used in subsequent calls to the API. The
        ///     execution of dependent subsequent calls will get postponed until this customer object gets active.
        ///     * active - The customer has been successfully set up.
        ///     * failed - The customer could not be set up.
        ///     * discarded - The customer has been discarded.
        ///     * expired - The customer has expired due to dormancy.
        /// </summary>
        [DataMember(Name = "state")]
        public string State { get; set; }

        /// <summary>
        ///     Customer’s salutation
        /// </summary>
        [DataMember(Name = "salutation")]
        public string Salutation { get; set; }

        /// <summary>
        ///     Customer’s given name. Required unless a company name is provided
        /// </summary>
        [DataMember(Name = "givenName")]
        public string GivenName { get; set; }

        /// <summary>
        ///     Customer’s family name. Required unless a company name is provided
        /// </summary>
        [DataMember(Name = "familyName")]
        public string FamilyName { get; set; }

        /// <summary>
        ///     Customer’s company name. Required unless a given name and family name are provided
        /// </summary>
        [DataMember(Name = "companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        ///     The first line of the customer’s address
        /// </summary>
        [DataMember(Name = "addressLine1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        ///     The second line of the customer’s address
        /// </summary>
        [DataMember(Name = "addressLine2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        ///     The third line of the customer’s address
        /// </summary>
        [DataMember(Name = "addressLine3")]
        public string AddressLine3 { get; set; }

        /// <summary>
        ///     The postal code of the customer’s address
        /// </summary>
        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        ///     The city of the customer’s address
        /// </summary>
        [DataMember(Name = "city")]
        public string City { get; set; }

        /// <summary>
        ///     The address region, county or department of the customer’s address
        /// </summary>
        [DataMember(Name = "region")]
        public string Region { get; set; }

        /// <summary>
        ///     The ISO 3166-1 alpha-2 country code of the customer’s address.
        /// </summary>
        [DataMember(Name = "countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     ISO 639-1 code. Used as the language for notification emails sent by SEPAexpress if
        ///     your organisation does not send its own (see compliance requirements). Currently
        ///     only “en”, “fr”, “de” are supported.
        ///     Defaults to the country code of the address or "en" if not supported
        /// </summary>
        [DataMember(Name = "languageCode")]
        public string LanguageCode { get; set; }

        /// <summary>
        ///     Customer’s email address.
        /// </summary>
        [DataMember(Name = "emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        ///     Customer’s telephone number. ITU-T E.164 formatted.
        /// </summary>
        [DataMember(Name = "telephone")]
        public string Telephone { get; set; }

        /// <summary>
        ///     Customer’s cellphone number. ITU-T E.164 formatted.
        /// </summary>
        [DataMember(Name = "cellphone")]
        public string Cellphone { get; set; }

        /// <summary>
        ///     The unique idempotency key of this entity creation.
        ///     Optional, but highly recommended to use. When given, SEPAexpress
        ///     will check, whether an entity of this type with the given
        ///     idempotency key does already exist, and will fail the creation,
        ///     if a duplicate entity is found. The error message will contain
        ///     the id of the conflicting entity.
        /// </summary>
        [DataMember(Name = "idempotencyKey")]
        public string IdempotencyKey { get; set; }

        /// <summary>
        ///     Memo for free use by the PSP
        /// </summary>
        [DataMember(Name = "memo")]
        public string Memo { get; set; }


    }
}