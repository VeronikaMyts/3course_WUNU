public class laba2 {
    double[] xValues;
    double[] yValues;
    private final double b = 1.5;

    // Обчислення значення функції
    public double calculateFunction(double x) {
        double bx = b * x;
        if (bx <= 0.45) {
            return bx - Math.tan(bx);
        } else {
            return bx * Math.log10(bx);
        }
    }

    // Обчислення кількості кроків для табуляції
    public int calculateSteps(double start, double end, double step) {
        return (int) Math.ceil((end - start) / step) + 1;
    }

    // Табулювання функції на заданому проміжку з заданим кроком
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

    // Пошук індексу максимального значення
    public int findMaxIndex() {
        int maxIndex = 0;
        for (int i = 1; i < yValues.length; i++) {
            if (yValues[i] > yValues[maxIndex]) {
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    // Пошук індексу мінімального значення
    public int findMinIndex() {
        int minIndex = 0;
        for (int i = 1; i < yValues.length; i++) {
            if (yValues[i] < yValues[minIndex]) {
                minIndex = i;
            }
        }
        return minIndex;
    }

    // Обчислення суми всіх значень y
    public double calculateSum() {
        double sum = 0;
        for (double y : yValues) {
            sum += y;
        }
        return sum;
    }

    // Обчислення середнього арифметичного значень y
    public double calculateAverage() {
        return calculateSum() / yValues.length;
    }

    // Отримання x-значення по індексу
    public double getXValue(int index) {
        return xValues[index];
    }

    // Отримання y-значення по індексу
    public double getYValue(int index) {
        return yValues[index];
    }

    // Виведення результатів
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
}

