namespace BigCommerce_Server.Models
{
    public class Order
    {
        private int _id;
        private int status_id;
        private int customer_id;
        private String subtotal_inc_tax;
        private String total_inc_tax;
        private String payment_method;
        private String payment_status;
        private String store_credit_amount;

    }
}
