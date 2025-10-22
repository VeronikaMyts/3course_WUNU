import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class laba2Test {
    @Test
    public void testCalculateFunction() {
        laba2 calculator = new laba2();
        assertEquals(0.15 - Math.tan(0.15), calculator.calculateFunction(0.1), 1e-6);
        assertEquals(0.75 * Math.log10(0.75), calculator.calculateFunction(0.5), 1e-6);
    }
    @Test
    public void testCalculateSteps() {
        laba2 calculator = new laba2();
        assertEquals(901, calculator.calculateSteps(0.1, 1.0, 0.001));
    }
    @Test
    public void testTabulateFunction() {
        laba2 calculator = new laba2();
        calculator.tabulateFunction(0.1, 0.2, 0.1);
        assertEquals(2, calculator.xValues.length);
        assertEquals(2, calculator.yValues.length);
    }

    @Test
    public void testFindMaxIndex() {
        laba2 calculator = new laba2();
        calculator.tabulateFunction(0.1, 1.0, 0.1);
        int maxIndex = calculator.findMaxIndex();

        for (int i = 0; i < calculator.yValues.length; i++) {
            assertTrue(calculator.getYValue(i) <= calculator.getYValue(maxIndex));
        }
    }

    @Test
    public void testFindMinIndex() {
        laba2 calculator = new laba2();
        calculator.tabulateFunction(0.1, 1.0, 0.1);
        int minIndex = calculator.findMinIndex();

        for (int i = 0; i < calculator.yValues.length; i++) {
            assertTrue(calculator.getYValue(i) >= calculator.getYValue(minIndex));
        }
    }

    @Test
    public void testCalculateSum() {
        laba2 calculator = new laba2();
        calculator.tabulateFunction(0.1, 1.0, 0.1);
        double sum = calculator.calculateSum();

        double expectedSum = 0;
        for (int i = 0; i < calculator.yValues.length; i++) {
            expectedSum += calculator.getYValue(i);
        }

        assertEquals(expectedSum, sum, 1e-6);
    }

    @Test
    public void testCalculateAverage() {
        laba2 calculator = new laba2();
        calculator.tabulateFunction(0.1, 1.0, 0.1);
        double average = calculator.calculateAverage();
        double expectedAverage = calculator.calculateSum() / calculator.yValues.length;

        assertEquals(expectedAverage, average, 1e-6);
    }
}
