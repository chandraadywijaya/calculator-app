class Calculator{
	static void Main(string[] args){
		int a = 10;
		int b = 6;
		
		console.WriteLine("Hasil Penambahan :{0} + {1} = {2}", a, b, penambahan(a, b));
		console.WriteLine("Hasil Pengurangan :{0} - {1} = {2}", a, b, pengurangan(a, b));
		console.WriteLine("Hasil Perkalian :{0} * {1} = {2}", a, b, perkalian(a, b));
		console.WriteLine("Hasil Pembagian :{0} \ {1} = {2}", a, b, pembagian(a, b));
		
		
		console.WriteLine("\nTekan sembarang key untuk keluar");
		console.ReadyKey();
		
	}
	
	static int Penambahan(int a, int b){
		return a + b;
	}
	
	static int pengurangan(int a, b){
		return a - b;
	}
}