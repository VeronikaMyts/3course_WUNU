public class ArrayProcessor {

    private double[] array;

    public ArrayProcessor(double[] array) {
        this.array = array;
    }

    public Double findMaxNegative() {
        Double maxNegative = null;
        for (double num : array) {
            if (num < 0 && (maxNegative == null || num > maxNegative)) {
                maxNegative = num;
            }
        }
        return maxNegative;
    }

    public Double findMinPositive() {
        Double minPositive = null;
        for (double num : array) {
            if (num > 0 && (minPositive == null || num < minPositive)) {
                minPositive = num;
            }
        }
        return minPositive;
    }

    public double averageEvenIndices() {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < array.length; i += 2) {
            sum += array[i];
            count++;
        }
        return count > 0 ? sum / count : 0;
    }

    public double sumLogAbsMaxMin() {
        double max = array[0];
        double min = array[0];
        for (double num : array) {
            if (num > max) {
                max = num;
            }
            if (num < min) {
                min = num;
            }
        }
        double logMax = Math.log(Math.abs(max));
        double logMin = Math.log(Math.abs(min));
        return logMax + logMin;
    }
}
