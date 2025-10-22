import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class MainWindow extends JFrame {
    private JTextField textFieldStart, textFieldEnd, textFieldStep;
    private JButton buttonCalculate;
    private JLabel labelMax, labelMin, labelAverage, labelSum;

    public MainWindow() {
        setTitle("Визначення функції");
        setSize(400, 300);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);

        // Створення компонентів
        textFieldStart = new JTextField(10);
        textFieldEnd = new JTextField(10);
        textFieldStep = new JTextField(10);
        buttonCalculate = new JButton("Обчислити");
        labelMax = new JLabel("Макс. значення: ");
        labelMin = new JLabel("Мін. значення: ");
        labelAverage = new JLabel("Середнє: ");
        labelSum = new JLabel("Сума: ");

        // Розміщення компонентів на формі
        JPanel panel = new JPanel();
        panel.add(new JLabel("X Start:"));
        panel.add(textFieldStart);
        panel.add(new JLabel("X End:"));
        panel.add(textFieldEnd);
        panel.add(new JLabel("Крок:"));
        panel.add(textFieldStep);
        panel.add(buttonCalculate);
        panel.add(labelMax);
        panel.add(labelMin);
        panel.add(labelAverage);
        panel.add(labelSum);
        add(panel);

        // Додавання обробника події для кнопки
        buttonCalculate.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                double xStart = Double.parseDouble(textFieldStart.getText());
                double xEnd = Double.parseDouble(textFieldEnd.getText());
                double step = Double.parseDouble(textFieldStep.getText());

                // Використання класу laba2
                laba2 calculator = new laba2();
                calculator.tabulateFunction(xStart, xEnd, step);

                // Виведення результатів
                int maxIndex = calculator.findMaxIndex();
                int minIndex = calculator.findMinIndex();
                double maxValue = calculator.getYValue(maxIndex);
                double minValue = calculator.getYValue(minIndex);
                double average = calculator.calculateAverage();
                double sum = calculator.calculateSum();

                labelMax.setText("Макс. значення: " + maxValue + " при x = " + calculator.getXValue(maxIndex));
                labelMin.setText("Мін. значення: " + minValue + " при x = " + calculator.getXValue(minIndex));
                labelAverage.setText("Середнє: " + average);
                labelSum.setText("Сума: " + sum);
            }
        });
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {
            @Override
            public void run() {
                new MainWindow().setVisible(true);
            }
        });
    }
}