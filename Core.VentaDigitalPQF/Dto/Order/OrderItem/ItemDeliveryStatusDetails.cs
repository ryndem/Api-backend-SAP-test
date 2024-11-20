namespace Core.VentaDigitalPQF.Dto.Order.OrderItem
{
    public class ItemDeliveryStatusDetails
    {
        /// <summary>
        /// Pedido Confirmado
        /// </summary>
        public bool? OrderConfirmed { get; set; }

        /// <summary>
        /// Fecha Pedido Confirmado
        /// </summary>
        public DateTime? OrderConfirmedDate { get; set; }

        /// <summary>
        /// Pedido En Tránsito
        /// </summary>
        public bool? OrderInTransit { get; set; }

        /// <summary>
        /// Fecha Pedido En Tránsito
        /// </summary>
        public DateTime? OrderInTransitDate { get; set; }

        /// <summary>
        /// En Compra
        /// </summary>
        public bool? InPurchase { get; set; }

        /// <summary>
        /// Fecha En Compra
        /// </summary>
        public DateTime? InPurchaseDate { get; set; }

        /// <summary>
        /// Producto Embarcado
        /// </summary>
        public bool? ProductShipped { get; set; }

        /// <summary>
        /// Fecha Producto Embarcado
        /// </summary>
        public DateTime? ProductShippedDate { get; set; }

        /// <summary>
        /// En Camino Almacén Matriz
        /// </summary>
        public bool? OnTheWayToMainWarehouse { get; set; }

        /// <summary>
        /// Fecha En Camino Almacén Matriz
        /// </summary>
        public DateTime? OnTheWayToMainWarehouseDate { get; set; }

        /// <summary>
        /// Almacén Matriz
        /// </summary>
        public bool? MainWarehouse { get; set; }

        /// <summary>
        /// Fecha Almacén Matriz
        /// </summary>
        public DateTime? MainWarehouseDate { get; set; }

        /// <summary>
        /// Rechazado En Inspección
        /// </summary>
        public bool? RejectedInInspection { get; set; }

        /// <summary>
        /// Fecha Rechazado En Inspección
        /// </summary>
        public DateTime? RejectedInInspectionDate { get; set; }

        /// <summary>
        /// Generar Aviso De Cambio
        /// </summary>
        public bool? GenerateChangeNotice { get; set; }

        /// <summary>
        /// Fecha Generar Aviso De Cambio
        /// </summary>
        public DateTime? GenerateChangeNoticeDate { get; set; }

        /// <summary>
        /// En Tránsito
        /// </summary>
        public bool? InTransit { get; set; }

        /// <summary>
        /// Fecha En Tránsito
        /// </summary>
        public DateTime? InTransitDate { get; set; }

        /// <summary>
        /// Pedido Entregado
        /// </summary>
        public bool? OrderDelivered { get; set; }

        /// <summary>
        /// Fecha Pedido Entregado
        /// </summary>
        public DateTime? OrderDeliveredDate { get; set; }
    }
}
