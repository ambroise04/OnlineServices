﻿using SandwichSystem.BusinessLayer.Extentions;
using SandwichSystem.Shared.TransfertObjects;
using System;

namespace SandwichSystem.BusinessLayer.UseCases.Assistante
{
    public partial class Assistante
    {
        public bool AddSupplier(SupplierTO Supplier)
        {
            try
            {
                if (Supplier is null)
                    throw new ArgumentNullException(nameof(Supplier));

                if (Supplier.Id != 0)
                    throw new Exception("Existing supplier");

                UnitOfWork.SupplierRepository.Insert(Supplier.ToDomain().ToTransfertObject());

                return true;
            }

            //TODO Code to test Unique Constraint on Name...
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
