// See https://aka.ms/new-console-template for more information
using System.Text;
using BenchmarkDotNet.Running;



//var summary = BenchmarkRunner.Run<StringTest>();


		//  Student[] arrStudent = new Student[] 
		//  { 
		// 	new Student() { Name = "Vikram", TotalMarks = 100 },
        //     new Student() { Name = "Abhishek" , TotalMarks = 90},
        //     new Student() { Name = "Greg", TotalMarks = 70 },
        //     new Student() { Name = "Thomas", TotalMarks = 80 }
		//  };
	
	    // Array.Sort(arrStudent, new MarksComparer());
		
		// foreach(var item in arrStudent)
		// {
		// 	Console.WriteLine(item.Name);	
		// }



 Console.WriteLine("Hello, World!");

 var pluginLoader = new PluginLoader();
 pluginLoader.Load();

// var txtEditor = new TextEditor();
		
// txtEditor.AppendText("Hello world");
// //txtEditor.Undo();
// txtEditor.AppendText("!");

// var curText1 = txtEditor.CurrentText;
// Console.WriteLine($"curText1 : {curText1}");
// txtEditor.Undo();

// //txtEditor.ExRedo();

// var curText2 = txtEditor.CurrentText;
// Console.WriteLine($"curText2 : {curText2}");
// txtEditor.Redo();

// var curText3 = txtEditor.CurrentText;
// Console.WriteLine($"curText3 : {curText3}");
// txtEditor.Undo();


// var curText4 = txtEditor.CurrentText;
// Console.WriteLine($"curText4 : {curText4}");


// var test = Singleton.Instance;

//        int i = 13;
//             int j = 14;
//             i = --i - i--;//i will be 0
//             j = ++j + j++;//j will be 30
//             Console.WriteLine(i+j);

// double d1 = 1.000001;
//             double d2 = 0.000001;
//             Console.WriteLine((d1 - d2));

// // int[] data = { 1, 2, 3 };
// //             int i = 1;
// //             data[i++] = data[i] + 10;
// //             Console.WriteLine(String.Join(",", data));

// 		    int x = 0;
//             int y = 0;
 
//             for (short z = 0; z < 5; z++) 
// 			{ 
// 				if ((++x > 3) || (++y > 3))
//                 {
//                     x++;
//                 }
//             }
//             Console.WriteLine (x+ "  " + y);



// // char x = 'X';
// //  int i = 0;
// // Console.WriteLine (x);
// // Console.WriteLine (true  ? x : 0);
// // Console.WriteLine(false ? i : x);
// // Console.WriteLine(x+1); 

// /*
// output:
// X
// 88
// 88
// 89
// */


// Nullable<int> nullableVariable1 = 1;
// int? nullableVariable2 = 1;
// int intVariable = 1;
// Console.WriteLine($"nullableVariable1.GetType() : {nullableVariable1.GetType()}");
// Console.WriteLine($"nullableVariable2.GetType() : {nullableVariable2.GetType()}");
// Console.WriteLine($"nullableVariable1.GetType() == nullableVariable2.GetType() : {nullableVariable1.GetType() == nullableVariable2.GetType()}");
// Console.WriteLine($"nullableVariable1 == nullableVariable2 : {nullableVariable1 == nullableVariable2}");
// Console.WriteLine($"Equals(nullableVariable1,nullableVariable2) : {Equals(nullableVariable1,nullableVariable2)}");
// Console.WriteLine($"ReferenceEquals(nullableVariable1,nullableVariable2) : {ReferenceEquals(nullableVariable1,nullableVariable2)}");
// Console.WriteLine($"nullableVariable1 == intVariable : {nullableVariable1 == intVariable}");
// Console.WriteLine($"intVariable.GetType() : {intVariable.GetType()}");

//         // Define a variable in the outer scope
//         int outerVariable = 5;

//         // Create a delegate with a closure (captures the outerVariable)
//         Action closure = () =>
//         {
//             Console.WriteLine("Value from closure: " + outerVariable);
//         };

//         // Invoke the delegate
//         closure();

//         // Modify the outerVariable
//         outerVariable = 10;

//         // Invoke the delegate again; it retains the captured value
//         closure();


// try{
//     double dVal = 100.1;
//     Console.WriteLine((int)dVal);

//     object objVal = dVal;
//     Console.WriteLine(objVal.GetType());
//     Console.WriteLine((int)objVal);
// }catch(Exception ex){
//     Console.WriteLine($"Exception : {ex.ToString()}");
// }

// //System.Console.WriteLine(Fibonacci.GetFibbonacci(10));

// //string ips = Console.ReadLine();

// // int end = ips.Length-1;
// // var sb = new StringBuilder();
// // while(end>=0){
// //     sb.Append(ips[end]);
// //     end--;
// // }
// // if(ips == sb.ToString()) Console.WriteLine("true");
// // else Console.WriteLine("false");

// int[] narr = {3,1,2,10,1};


// var outp = runningSum(narr);

// System.Console.WriteLine("end");

// static int[] runningSum(int[] n)
// {
//     int sum = 0;
//     int ind = 0;
//     foreach(var item in n){
//         sum += item;
//         n[ind] = sum;
//         ind++;
//     }
//     return n;
// }
