using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace YouTubeEgitim
{
	class Program
	{
		static void Main(String[] args)
		{
			
			CustomerManager customerManager = new CustomerManager (new Customer(), new MilitaryCreditManager ());
			customerManager.GiveCredit();
			

			




        Console.ReadLine();
		}
	}
			
		}
	
	class CreditManager
	{
	public void Calculate(int creditType)
	{
		if (creditType == 1)//esnaf
		{ 
		
		}
		if (creditType == 2)//ogretmen
		{ 
		
		}

			Console.WriteLine("Hesaplandı");
		}
		public void Save()
		{
			Console.WriteLine("  Kredi Verildi");
		}
	   
	}

interface ICreditManager
{
	void Calculate();
	void Save();
}


abstract class BaseCreditManager : ICreditManager
{
	public abstract void Calculate();

	public virtual void Save()
	{
		Console.WriteLine("Kaydedildi");
	}
}

class TeacherCreditManager : BaseCreditManager, ICreditManager
{
	public override void Calculate()
	{
		//Hesaplamalar
		Console.WriteLine("Öğretmen Kredisi Hesaplandı");
	}
	public override void Save()
	{
		//
		base.Save();
		//
	}

}


class MilitaryCreditManager : BaseCreditManager,ICreditManager
{
	public override void Calculate()
	{
		Console.WriteLine("Asker Krediisi Hesaplandı");
	}

	public void Save()
	{
		Console.WriteLine("Kaydedildi");
	}
}



class Customer
{
	public Customer()
	{
		Console.WriteLine("Müşteri Nesnesi başladı");
	}
	public int Id { get; set; }
	public string TaxNumber { get; set; }
	public string City { get; set; }
	public string CompanyName{get;set;}
	public string FirstName{get;set;}
}


class Personel : Customer
{
	public string NationalIdentity { get; set; }
	public string FirstName { get; set; }
	}



class Company : Customer
{


	}
	//Katmanlı Mimariler
	class CustomerManager
	{

		private Customer _customer;
	private ICreditManager _creditManager;
		public CustomerManager(Customer customer,ICreditManager creditManager)
		{
			_customer = customer;
		    _creditManager = creditManager;
		}
		public void Save()
		{
			Console.WriteLine("Müşteri Kaydedildi :" );
		}
	public void Delete()
	{
		Console.WriteLine("Müşteri Silindi:");

	}
	public void GiveCredit()
	{
		_creditManager.Calculate();
		Console.WriteLine("Kredi Verildi");

			

		}
	}














