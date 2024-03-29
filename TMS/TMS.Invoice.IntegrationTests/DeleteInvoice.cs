﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Invoice.DI;
using TMS.Invoice.Domain.Services;
using TMS.Invoice.Service.Model;
using TMS.Invoice.Service.Service;

namespace TMS.Invoice.IntegrationTests
{
    [TestClass]
    public class DeleteInvoice
    {
        [TestMethod]
        public void VaiApagarUmReciboQueNaoExiste()
        {
            // Arrange
            var container = BootStrapDI.Bootstrap();

            InvoiceService invoiceService = new InvoiceService(container.GetInstance<InvoiceDomainService>());

            // Act
            bool invoiceResult = invoiceService.Delete(Guid.NewGuid());

            // Assert
            Assert.IsFalse(invoiceResult);
        }

        [TestMethod]
        public void VaiApagarUmRecibo()
        {
            // Arrange
            var container = BootStrapDI.Bootstrap();

            InvoiceService InvoiceService = new InvoiceService(container.GetInstance<InvoiceDomainService>());

            Guid invoiceId = Guid.NewGuid();

            InvoiceDto invoice = new InvoiceDto()
            {
                AppointmentID = Guid.NewGuid(),
                ClientID = Guid.NewGuid(),
                Id = invoiceId,
                InvoiceDate = DateTime.Now,
                Price = decimal.One
            };

            // Act
            List<string> result = InvoiceService.Create(invoice);

            bool invoiceResult = InvoiceService.Delete(invoiceId);

            // Assert
            Assert.IsTrue(result.Count == 0);
            Assert.IsTrue(invoiceResult);
        }
    }
}
