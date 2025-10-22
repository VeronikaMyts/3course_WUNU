import java.util.Arrays;
import java.util.Comparator;
import java.util.Scanner;

class Phone{
    private int id;
    private String lastName;
    private String firstName;
    private String middleName;
    private String address;
    private String creditCardNumber;
    private double debit;
    private double credit;
    private int cityTalkTime;
    private int intercityTalkTime;

    public Phone(int id, String lastName, String firstName, String middleName, String address, String creditCardNumber, double debit, double credit, int cityTalkTime, int intercityTalkTime) {
        this.id = id;
        this.lastName = lastName;
        this.firstName = firstName;
        this.middleName = middleName;
        this.address = address;
        this.creditCardNumber = creditCardNumber;
        this.debit = debit;
        this.credit = credit;
        this.cityTalkTime = cityTalkTime;
        this.intercityTalkTime = intercityTalkTime;
    }

    public int getCityTalkTime(){
        return cityTalkTime;
    }

    public int getIntercityTalkTime(){
        return intercityTalkTime;
    }

    public String getLastName() {
        return lastName;
    }

    public String toString(){
        return id + ". " + lastName + ", " + firstName + ", " + middleName + ", " + address + ", " + creditCardNumber + ", " + debit + ", " + credit + ", " + cityTalkTime + " хв," + intercityTalkTime+ " хв,";
    }
}

public class Main {
    public static void main(String[] args) {
        Phone[] phones = {
                new Phone(1, "Назарчук", "Софія", "Андріївна", "Київ", "1234-5678", 100.0, 200.0, 50, 0),
                new Phone(2, "Ковальчук", "Петро", "Валентинович", "Львів", "2345-6789", 120.0, 150.0, 100, 20),
                new Phone(3, "Фурманенко", "Сидір", "Вікторович", "Одеса", "3456-7890", 90.0, 180.0, 20, 10)
        };

        Scanner sc = new Scanner(System.in);

        System.out.print("Введіть поріг для часу міських розмов : ");
        int limit = sc.nextInt();

        System.out.println("\n Абоненти з міськими розмовами більше:"+ limit +  "хв:");
        boolean found = false;
        for (Phone p : phones) {
            if (p.getCityTalkTime() > limit) {
                System.out.println(p);
                found = true;
            }
        }
        if (!found) {
            System.out.println("Немає абонентів, у яких міські розмови перевищують " + limit + " хв.");
        }

        System.out.println("\n Абонент, які користувались міжміським зв'язком: ");
        found = false;
        for (Phone p : phones) {
            if (p.getIntercityTalkTime() > 0) {
                System.out.println(p);
                found = true;
            }
        }
        if (!found) {
            System.out.println("Немає абонентів, які користувались міжміським зв’язком.");
        }
        System.out.println("\n Абоненти в алфавітному порядку: ");
        Arrays.sort(phones, Comparator.comparing(Phone::getLastName));
        for(Phone p: phones){
            System.out.println(p);
        }
    }
}