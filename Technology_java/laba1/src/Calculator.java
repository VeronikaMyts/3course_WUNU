import java.text.SimpleDateFormat;
import java.util.Date;
public class Calculator {
    private double a=1.1, b=0.004, x=0.2;
    private double y, z;

    public void calculator(){
        y = Math.pow(Math.sin(Math.pow((x*x+a), 2)), 3) -Math.sqrt(x/b);
        z = (x*x/a)+ Math.pow(Math.cos(x+b),3);
    }

    public void  printResults(){
        System.out.println("Вхідні дані:");
        System.out.println("a="+a);
        System.out.println("b="+b);
        System.out.println("x="+x);

        System.out.println("Результат:");
        System.out.println("y="+y);
        System.out.println("z="+z);
    }

    //Для друку дати і часу
    public void printCurrentDateTime(){
        SimpleDateFormat formatter = new SimpleDateFormat("EEE, d MMM ");
        Date date = new Date();
        System.out.println("Поточна дата : " + formatter.format(date));
    }

    public static void main(String[] args) {
        Calculator calculator = new Calculator();

        calculator.calculator();
        calculator.printResults();
        calculator.printCurrentDateTime();

    }
}
