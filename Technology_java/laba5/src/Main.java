import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.io.*;
import java.util.Locale;


public class Main {
    private static  List<Toy> toys = new ArrayList<>();
    public  static final String FILE_NAME= "toys.txt";

    public static void main(String[] args) {
        loadToysFromFile();

        System.out.println("Програма керування іграшками запущена.");

        Scanner scanner = new Scanner(System.in);
        scanner.useLocale(Locale.US);
        int choice;

        do{
            System.out.println("\n Меню:");
            System.out.println("1. Додати нову іграшку");
            System.out.println("2. Переглянути всі іграшки");
            System.out.println("3. Виконати запит: знайти м'ячі для дітей 3-8 років за ціною");
            System.out.println("0. Вихід");
            System.out.println("Ваш вибір: ");
            choice = scanner.nextInt();
            scanner.nextLine();

            switch (choice) {
                case 1:
                    addToy(scanner);
                    break;
                case 2:
                    viewToys();
                    break;
                case 3:
                    searchBalls(scanner);
                    break;
                case 0:
                    saveToysToFile();
                    System.out.println("Завершення програми...");
                    break;
                default:
                    System.out.println("Невірний вибір. Спробуйте ще раз");
            }
        } while (choice !=0);

        scanner.close();
    }
    private static void saveToysToFile(){
        try(PrintWriter writer = new PrintWriter(new FileWriter(FILE_NAME))){
            for (Toy toy : toys){
                if (toy instanceof Ball) {
                    Ball ball = (Ball) toy;
                    writer.println("Ball;"+ball.getName()+ ";"+ball.getPrice()+";"+ ball.getMinAge()+";"+ball.getMaxAge()+";"+ ball.getWeight());
                }else{
                    writer.println("Toy;"+toy.getName()+";"+toy.getPrice()+";"+toy.getMinAge()+";"+toy.getMaxAge());
                }
            }
            System.out.println("Дані збережено у файл.");
        }catch (IOException e){
            System.out.println("Помилка при збережені файлі: "+e.getMessage());
        }
    }
    private static  void  loadToysFromFile(){
        toys.clear();
        try(BufferedReader reader = new BufferedReader(new FileReader(FILE_NAME))){
            String line;
            while ((line=reader.readLine())!=null){
                String[] parts = line.split(";");
                if(parts[0].equals("Ball")){
                    toys.add(new Ball(parts[1],Integer.parseInt(parts[2]),Integer.parseInt(parts[3]),Integer.parseInt(parts[4]),Double.parseDouble(parts[5])));
                } else if (parts[0].equals("Toy")){
                    toys.add(new Toy(parts[1],Integer.parseInt(parts[2]),Integer.parseInt(parts[3]),Integer.parseInt(parts[4])));
                }
            }
            System.out.println("Дані завантажено з файлу.");
        }catch (FileNotFoundException e){
            System.out.println("Файл не знайдено.Створюємо новий файл при збереження");
        }catch (IOException e){
            System.out.println("Помилка при читанні файлу: "+e.getMessage());
        }
    }
    private static void addToy(Scanner scanner) {
        String type;
        while (true) {
            System.out.println("Введіть тип іграшки (лялька/кубики/м'яч/конструктор): ");
            type = scanner.nextLine().toLowerCase();
            if (type.equals("лялька") || type.equals("кубики") || type.equals("м'яч") || type.equals("конструктор")) {
                break;
            } else {
                System.out.println("Невідомий тип іграшки. Спробуйте ще раз.");
            }
        }

        String name;
        while (true) {
            System.out.println("Введіть назву іграшки: ");
            name = scanner.nextLine();
            if (!name.trim().isEmpty()) {
                break;
            } else {
                System.out.println("Назва не може бути порожньою.");
            }
        }

        int price = 0;
        while (true) {
            System.out.println("Введіть ціну (у копійках): ");
            if (scanner.hasNextInt()) {
                price = scanner.nextInt();
                if (price > 0) {
                    break;
                } else {
                    System.out.println("Ціна має бути більшою за 0.");
                }
            } else {
                System.out.println("Ціна має бути числом.");
                scanner.next();
            }
        }

        int minAge = 0;
        while (true) {
            System.out.println("Введіть мінімальний вік: ");
            if (scanner.hasNextInt()) {
                minAge = scanner.nextInt();
                if (minAge >= 0) {
                    break;
                } else {
                    System.out.println("Вік не може бути від'ємним.");
                }
            } else {
                System.out.println("Вік має бути числом.");
                scanner.next();
            }
        }

        int maxAge = 0;
        while (true) {
            System.out.println("Введіть максимальний вік: ");
            if (scanner.hasNextInt()) {
                maxAge = scanner.nextInt();
                if (maxAge >= minAge) {
                    break;
                } else {
                    System.out.println("Максимальний вік має бути більший або рівний мінімальному.");
                }
            } else {
                System.out.println("Вік має бути числом.");
                scanner.next();
            }
        }


        if (type.equals("м'яч")) {
            double weight = 0;
            while (true) {
                System.out.println("Введіть вагу м'яча (у грамах): ");
                if (scanner.hasNextDouble()) {
                    weight = scanner.nextDouble();
                    if (weight > 0) {
                        break;
                    } else {
                        System.out.println("Вага повинна бути більшою за нуль.");
                    }
                } else {
                    System.out.println("Вага має бути числом.");
                    scanner.next();
                }
            }
            toys.add(new Ball(name, price, minAge, maxAge, weight));
        } else {
            toys.add(new Toy(name, price, minAge, maxAge));
        }

        System.out.println("Іграшку додано.");
        scanner.nextLine();
    }
    private static void viewToys() {
        if(toys.isEmpty()){
            System.out.println("Список іграшок порожній.");
        }else{
            System.out.println("\nСписок іграшок: ");
            for(Toy toy : toys){
                System.out.println(toy);
            }
        }
    }
    private static void searchBalls(Scanner scanner) {
        System.out.print("Введіть максимальну ціну м'яча(у копійках):  ");
        int maxPrice = scanner.nextInt();

        List<Ball> foundBalls = new ArrayList<>();

        for(Toy toy : toys){
            if(toy instanceof Ball){
                Ball ball = (Ball) toy;
                if(ball.getPrice() <= maxPrice && ball.getMinAge()<= 3 && ball.getMaxAge()>= 8){
                    foundBalls.add(ball);
                }
            }
        }
        foundBalls.sort((b1, b2) -> Integer.compare(b1.getPrice(), b2.getPrice()));

        if (foundBalls.isEmpty()) {
            System.out.println("М'ячі за заданими умовами не знайдені.");
        } else {
            System.out.println("\nПерелік знайдених м'ячів: ");
            for (Ball ball : foundBalls){
                System.out.println(ball);
            }
        }
    }
}


