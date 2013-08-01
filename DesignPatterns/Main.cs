using System;

namespace DesignPatterns
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Abstract factory #1

			Console.WriteLine ("======= Abstract Factory =======");

			AbstractFactory factory1 = new ConcreteFactory1();
			Client client1 = new Client(factory1);
			client1.Run();
			
			// Abstract factory #2
			AbstractFactory factory2 = new ConcreteFactory2();
			Client client2 = new Client(factory2);
			client2.Run();

			VocaloidFactory vocaloidFactory = new ConcreteVocaloidFactory ();
			AbstractVocaloid hatsuneMiku = vocaloidFactory.CreateAVocaloid ();
			AbstractVocaloid anotherMiku = vocaloidFactory.CreateAMiku ();
			hatsuneMiku.singForMe();
			anotherMiku.singForMe();

			Console.WriteLine ("\n======= Factory Method =======");

			Document[] documents = new Document[2];
			documents [0] = new Resume ();
			documents [1] = new Report ();

			foreach (Document document in documents) {
				Console.WriteLine ("\n" + document.GetType ().Name + "--");
				foreach(Page page in document.Pages){
					Console.WriteLine (" " + page.GetType().Name);
				}
			}

			Console.WriteLine ("\n======= Singleton Method =======\n");

			Singleton s1 = Singleton.Instance();
			Singleton s2 = Singleton.Instance ();

			if (s1 == s2) {
				Console.WriteLine ("Objects are the same instance");
			}

			// Wait for user input
			Console.ReadKey();


		}
	}
}
