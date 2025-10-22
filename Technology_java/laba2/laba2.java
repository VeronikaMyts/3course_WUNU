import java.util.Arrays;
public class laba2 {
    double[] xValues;
    double[] yValues;
    private final double b=1.5;


    public double calculateFunction(double x) {
        double bx = b * x;
        if (bx <= 0.45) {
            return bx - Math.tan(bx);
        } else {
            return bx * Math.log10(bx);
        }
    }

    public int calculateSteps(double start, double end, double step) {
        return (int) Math.ceil((end - start) / step) + 1;
    }
    public void tabulateFunction(double start, double end, double step) {
        int size = calculateSteps(start, end, step);
        xValues = new double[size];
        yValues = new double[size];

        for (int i = 0; i < size; i++) {
            double x = start + i * step;
            xValues[i] = x;
            yValues[i] = calculateFunction(x);
        }
    }
    public int findMaxIndex() {
        int maxIndex = 0;
        for (int i = 1; i < yValues.length; i++) {
            if (yValues[i] > yValues[maxIndex]) {
                maxIndex = i;
            }
        }
        return maxIndex;
    }
    public int findMinIndex() {
        int minIndex = 0;
        for (int i = 1; i < yValues.length; i++) {
            if (yValues[i] < yValues[minIndex]) {
                minIndex = i;
            }
        }
        return minIndex;
    }
    public double calculateSum() {
        double sum = 0;
        for (double y : yValues) {
            sum += y;
        }
        return sum;
    }

    public double calculateAverage() {
        return calculateSum() / yValues.length;
    }

    public double getXValue(int index) {
        return xValues[index];
    }

    public double getYValue(int index) {
        return yValues[index];
    }
    public void printResults() {
        int maxIndex = findMaxIndex();
        int minIndex = findMinIndex();

        System.out.println("Максимальне значення y: " + yValues[maxIndex] +
                " при x = " + xValues[maxIndex] + ", індекс: " + maxIndex);
        System.out.println("Мінімальне значення y: " + yValues[minIndex] +
                " при x = " + xValues[minIndex] + ", індекс: " + minIndex);
        System.out.println("Сума значень y: " + calculateSum());
        System.out.println("Середнє арифметичне значень y: " + calculateAverage());
    }
    public static void main(String[] args) {
        laba2 calculator = new laba2();
        calculator.tabulateFunction(0.1, 1.0, 0.001);
        calculator.printResults();
    }

}

