﻿using SandwichSystem.BusinessLayer.Domain;
using SandwichSystem.Shared;
using SandwichSystem.Shared.BTO;
using SandwichSystem.Shared.DTO;
using System;
using System.Linq;

namespace SandwichSystem.BusinessLayer.Extentions
{
    public static class SupplierExtensions
    {
        public static SupplierBTO ToBTO(this Supplier Supplier)
        {
            return new SupplierBTO
            {
                Id = Supplier.Id,
                Name = Supplier.Name
            };
        }
        public static Supplier ToDomain(this SupplierBTO SupplierBTO)
        {
            try
            {
                var SupplierDomain = new Supplier()
                {
                    Id = SupplierBTO.Id,
                    Name = SupplierBTO.Name
                };

                SupplierDomain.IsValid();

                return SupplierDomain;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Supplier ToDomain(this SupplierDTO SupplierDTO)
        {
            return new Supplier()
            {
                Id = SupplierDTO.Id,
                Name = SupplierDTO.Name
            };
        }
        public static SupplierDTO ToDTO(this Supplier Supplier)
        {
            return new SupplierDTO
            {
                Id = Supplier.Id,
                Name = Supplier.Name
            };
        }
    }
}
