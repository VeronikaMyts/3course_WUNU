public class Toy {
    protected String name;
    protected int price;
    protected int minAge;
    protected int maxAge;

    public Toy(String name, int price, int minAge, int maxAge) {
        this.name = name;
        this.price = price;
        this.minAge = minAge;
        this.maxAge = maxAge;
    }

    public String getName() {
        return name;
    }

    public int getPrice() {
        return price;
    }

    public int getMinAge() {
        return minAge;
    }

    public int getMaxAge() {
        return maxAge;
    }

    public String toString() {
        return "Іграшка: " + name + ", Ціна: " + price + " копійок, Вік: "+ minAge+ "-" + maxAge + " років";
    }
}
