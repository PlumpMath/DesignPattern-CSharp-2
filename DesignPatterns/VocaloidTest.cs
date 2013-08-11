using System;

namespace DesignPatterns
{
	abstract class VocaloidFactory {
		public abstract AbstractVocaloid CreateAVocaloid();
		public abstract AbstractVocaloid CreateAMiku();
	}

	class ConcreteVocaloidFactory : VocaloidFactory {
		public override AbstractVocaloid CreateAVocaloid(){
			return new Vocaloid();
		}
		public override AbstractVocaloid CreateAMiku(){
			return new Miku();
		}
	}

	abstract class AbstractVocaloid {
		public abstract void singForMe();
	}

	class Vocaloid : AbstractVocaloid {
		public override void singForMe(){
			Console.WriteLine(this.GetType ().Name + " singing for you");
		}
	}

	class Miku : AbstractVocaloid {
		public override void singForMe(){
			Console.WriteLine (this.GetType().Name + " singing for you");
		}
	}
}

