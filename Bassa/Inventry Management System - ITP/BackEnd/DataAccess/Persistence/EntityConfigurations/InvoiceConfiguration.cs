﻿using DataAccess.Core.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Persistence.EntityConfigurations
{
    public class InvoiceConfiguration : EntityTypeConfiguration<Invoice>
    {
        public InvoiceConfiguration()
        {
            //Primary Key
            HasKey(i => i.InvoiceID).ToTable("Invoices");
            //Unique key
<<<<<<< HEAD
            Property(i => i.InvoicPublicID).IsRequired();
            Property(i => i.InvoicPublicID).HasMaxLength(20);
            Property(i => i.InvoicPublicID)
=======
            Property(i => i.InvoicePublicID).IsRequired();
            Property(i => i.InvoicePublicID).HasMaxLength(20);
            Property(i => i.InvoicePublicID)
>>>>>>> Bassa
                    .HasColumnAnnotation("InvoicePublicID", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));
            //Foreign Key
            HasRequired(i => i.IssuedBy).WithMany(e => e.IssuedInvoices)
                .HasForeignKey(i => i.IssuedByID).WillCascadeOnDelete(false);
            //Optional InvoiceCustomer attribute
            //HasOptional(op => op.InvoiceCustomer).WithOptionalPrincipal(p => p.Invoice);
        }
    }
}
