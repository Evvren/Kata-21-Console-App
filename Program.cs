using SimpleList;

var service = new SimpleListService();

        int option;
        bool? listSelectedIsSingley = null;
        bool correctAnswer = false;

        string holder;
        int intHolder;
        string input;

        while(correctAnswer != true){
        Console.Clear();
        Console.WriteLine("Welcome to my List implementations. Select 1 for Single link list or Select 2 for Double link list. ");

        if(correctAnswer == true){
            break;
        }
        try{
            int answer = int.Parse(Console.ReadLine());

                if(answer == 1){    
                    listSelectedIsSingley = true;
                    correctAnswer = true;
                } else if (answer == 2){
                    listSelectedIsSingley = false;
                    correctAnswer = true;
                }
        } catch {
        }
        }

        if(listSelectedIsSingley == true){
            bool returnMenu = false;
            while(returnMenu != true){

                Console.Clear();
                Console.WriteLine("Single Linked List Implementation");
                Console.WriteLine("");
                Console.WriteLine("This is how the list looks in its current state: ");
                Console.WriteLine("");
                Console.WriteLine("            [ " +string.Join(" , ", service.Display_S())+" ]");
                Console.WriteLine("");
                Console.WriteLine("What do you intend to do with it ?  Add (1) Delete (2) Search (3) Exit (4)");
                Console.WriteLine("");
                holder = Console.ReadLine();

                    try{
                        intHolder = int.Parse(holder);
                        if (intHolder == 1){
                            Console.WriteLine("Input what you want to add: ");
                            Console.WriteLine("");
                            input = Console.ReadLine();
                            service.Add_S(input);
                        } else if (intHolder == 2){
                            Console.WriteLine("Input what you want to delete: ");
                            Console.WriteLine("");
                            input = Console.ReadLine();
                            service.Delete_S(input);
                        } else if (intHolder == 3) {
                            Console.WriteLine("Input what you want to search for: ");
                            Console.WriteLine("");
                            input = Console.ReadLine();

                            var result = service.Find_S(input);

                            if (result.node == null){
                                Console.WriteLine("");
                                Console.WriteLine(result.error);
                                Console.ReadKey();
                            } else {
                                Console.WriteLine("");
                                Console.WriteLine("Value [ " + result.node.information.Value + " ] was found in the array.");

                                if(result.node.nextNode.information.Value == null){
                                    Console.WriteLine("This was the last value so it doesn't have a node past it.");
                                    Console.ReadKey();
                                    
                                } else {
                                    Console.WriteLine("That value has [ " + result.node.nextNode.information.Value + " ] in the next node.");
                                    Console.ReadKey();
                                }
                            }
                        } else if (intHolder == 4){
                                returnMenu = true;
                        }
                    } catch {
                    }

            }
            
        } else if(listSelectedIsSingley == false) {
            bool returnMenu = false;
            while(returnMenu != true){

                Console.Clear();
                Console.WriteLine("Double Link List Implementation");
                Console.WriteLine("");
                Console.WriteLine("This is how the list looks in its current state: ");
                Console.WriteLine("");
                Console.WriteLine("            [ " +string.Join(" , ", service.Display_D())+" ]");

                Console.WriteLine("");
                Console.WriteLine("What do you intend to do with it ?  Add (1) Delete (2) Search (3) Exit (4)");
                Console.WriteLine("");
                holder = Console.ReadLine();

                    try{
                        intHolder = int.Parse(holder);
                        if (intHolder == 1){
                            Console.WriteLine("Input what you want to add: ");
                            Console.WriteLine("");
                            input = Console.ReadLine();
                            service.Add_D(input);
                        } else if (intHolder == 2){
                            Console.WriteLine("Input what you want to delete: ");
                            Console.WriteLine("");
                            input = Console.ReadLine();
                            service.Delete_D(input);
                        }else if (intHolder == 3){
                            Console.WriteLine("Input what you want to search for: ");
                            Console.WriteLine("");
                            input = Console.ReadLine();

                            var result = service.Find_D(input);

                            if (result.node == null){
                                Console.WriteLine("");
                                Console.WriteLine(result.error);
                                Console.ReadKey();
                            } else {
                                Console.WriteLine("");
                                Console.WriteLine("Value [ " + result.node.information.Value + " ] was found in the array.");
                                Console.ReadKey();

                                if(result.node.previousNode.information.Value != null){
                                    Console.WriteLine("That value has [ " + result.node.previousNode.information.Value + " ] in the previous node.");
                                } else {
                                    Console.WriteLine("This was the first value so it doesn't have a node behind it.");
                                }

                                if(result.node.nextNode.information.Value != null){
                                    Console.WriteLine("That value has [ " + result.node.nextNode.information.Value + " ] in the next node.");
                                } else {
                                    Console.WriteLine("This was the last value so it doesn't have a node past it.");
                                }
                                
                                

                                Console.ReadKey();
                            }

                            
                        } else if (intHolder == 4){
                                returnMenu = true;
                        }
                    } catch {
                    }
        }
}

Console.Clear();
