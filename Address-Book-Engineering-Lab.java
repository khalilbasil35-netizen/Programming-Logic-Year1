

/*الاسم :خليل باسل خليل ابو كويك \ شعبة العملي :  103  \شعبة النظري :102 \ID:120254451

الاسم :يوسف عمار خليل ابو كويك \ شعبة العملي :  108  \شعبة النظري :106  \ID:120254444       

الاسم :علاء جمال علي اليازوري   \ شعبة العملي : 107   \شعبة النظري :105 \ID:120259904*/
package input;
import java.util.Scanner;

public class khalilbasilkwaik_120254451 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        
        String[] name = new String[100];
        String[] type = new String[100];
        String[] number = new String[100];
        
        int count = 0; 
        int choice = 0;
        
        do {
            System.out.println("\nWelcome to our Address book...");
            System.out.println("1. Add new contact.");
            System.out.println("2. Search by name.");
            System.out.println("3. Search by number.");
            System.out.println("4. Delete contact by name.");
            System.out.println("5. Delete contact by number.");
            System.out.println("6. Show all contacts.");
            System.out.println("7. Exit");
            System.out.print("Please enter your choice: ");
            
            choice = input.nextInt();
            input.nextLine(); 

            switch (choice) {
                case 1:
                    if (count < 100) {
                        System.out.print("Enter name: ");
                        String tempName = input.nextLine();
                        
                        System.out.print("Enter type [Family, Personal, Work, Other]: ");
                        String inputType = input.nextLine();
                        String tempType;
                        
                        if (inputType.equalsIgnoreCase("Family") || 
                            inputType.equalsIgnoreCase("Personal") || 
                            inputType.equalsIgnoreCase("Work") || 
                            inputType.equalsIgnoreCase("Other")) {
                            tempType = inputType;
                        } else {
                            tempType = "Other";
                            System.out.println("(!) Notice: Invalid type. Set to 'Other' by default.");
                        }
                        System.out.print("Enter number: ");
                        String tempNumber = input.nextLine();
                        
                        boolean isDuplicate = false;
                        for (int i = 0; i < count; i++) {
                            if (number[i].equals(tempNumber)) {
                                isDuplicate = true;
                                break;
                            }
                        }
                        
                        if (isDuplicate) {
                            System.out.println("Error: This number (" + tempNumber + ") already exists! Contact not added.");
                        } else {
                            name[count] = tempName;
                            type[count] = tempType;
                            number[count] = tempNumber;
                            count++;
                            System.out.println("Contact saved successfully.");
                        }
                    } else {
                        System.out.println("Error: Address book is full!");
                    }
                    break;

                case 2:
                    System.out.print("Enter name (or part of it) to search: ");
                    String sName = input.nextLine().toLowerCase();
                    boolean f1 = false;
                    for (int i = 0; i < count; i++) {
                        if (name[i].toLowerCase().contains(sName)) {
                            System.out.println("Found -> " + name[i] + " | " + type[i] + " | " + number[i]);
                            f1 = true;
                        }
                    }
                    if (!f1) System.out.println("Not found.");
                    break;

                case 3:
                    System.out.print("Enter number (or part of it) to search: ");
                    String sNum = input.nextLine();
                    boolean f2 = false;
                    for (int i = 0; i < count; i++) {
                        if (number[i].contains(sNum)) {
                            System.out.println("Found -> " + name[i] + " | " + type[i] + " | " + number[i]);
                            f2 = true;
                        }
                    }
                    if (!f2) System.out.println("Not found.");
                    break;

                case 4:
                    System.out.print("Enter name to delete: ");
                    String delN = input.nextLine();
                    boolean d1 = false;
                    for (int i = 0; i < count; i++) {
                        if (name[i].equalsIgnoreCase(delN)) {
                            for (int j = i; j < count - 1; j++) {
                                name[j] = name[j + 1];
                                type[j] = type[j + 1];
                                number[j] = number[j + 1];
                            }
                            count--;
                            d1 = true;
                            i--; 
                        }
                    }
                    if (d1) System.out.println("Contact(s) deleted.");
                    else System.out.println("Name not found.");
                    break;

                case 5:
                    System.out.print("Enter number to delete: ");
                    String deleteNumber = input.nextLine();
                    boolean deleted = false;
                    for(int i = 0; i < count; i++) {
                        if(number[i].equals(deleteNumber)) {
                            for(int j = i; j < count - 1; j++) {
                                name[j] = name[j + 1];
                                type[j] = type[j + 1];
                                number[j] = number[j + 1];
                            }
                            count--;
                            deleted = true;
                            break; 
                        }
                    }
                    if(!deleted) System.out.println("Not found");
                    else System.out.println("Contact deleted");
                    break;

                case 6:
                    if (count == 0) System.out.println("The list is empty.");
                    for(int i = 0; i < count; i++) {
                        System.out.println((i + 1) + ". " + name[i] + " (" + type[i] + ") - " + number[i]);
                    }
                    break;

                case 7:
                    System.out.println("The system will exit");
                    break;

                default:
                    System.out.println("Error: please choice a number bettwen 1 to 7 .");
            }
        } while (choice != 7);
    }
}