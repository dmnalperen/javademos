public class CustomerManager {
    ICustomerDal customerDal;
    public CustomerManager(){
        this.customerDal = customerDal;

    }
    public  void add(){
        //iş kodları
        customerDal.add();
    }

}
