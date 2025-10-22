import java.util.*;

public class TextMod{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);

        System.out.print("Введіть кількість рядків: ");
        int n = Integer.parseInt(sc.nextLine());

        System.out.println("Вводьте кожен рядок у форматі:");
        System.out.println("  Якщо ознака 0: 0 символ текст");
        System.out.println("  Якщо ознака 1: 1 символ k текст");
        System.out.println("  Наприклад: 0 і Привіт");
        System.out.println("            1 а 2 Привіт");


        for (int i = 0; i < n; i++){
            String s = sc.nextLine();
            String[] parts = s.split(" ",4);

            int flag = Integer.parseInt(parts[0]);
            char symbol = parts[1].charAt(0);

            String result = "";

            if (flag == 0){
                result = parts[2].replace(String.valueOf(symbol),"");
            } else if (flag == 1){
                int k = Integer.parseInt(parts[2]);
                String text = parts[3];

                if(k >=text.length()){
                    result = text + symbol;
                }else {
                    result = text.substring(0,k+1)+symbol+text.substring(k+1);
                }
            }

            System.out.println("Результат : " + result);
        }
        sc.close();
    }
}