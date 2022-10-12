public class Main {
    public static void main(String[] args) {
        CustomerManager customerManager = new CustomerManager();
        customerManager.customerDal = (ICustomerDal) new OracleCustomerDal();
        customerManager.add();
    }
}