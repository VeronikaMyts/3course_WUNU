public class Ball extends Toy{
    private double weight;

    public Ball(String name, int price , int minAge , int maxAge, double weight) {
        super(name, price, minAge, maxAge);
        this.weight = weight;
    }

    public  double getWeight() {
        return weight;
    }

    public  String toString() {
        return super.toString()+ ", Вага: "+ weight + "г";
    }
}



