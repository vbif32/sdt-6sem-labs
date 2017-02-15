import java.util.Scanner;

public class LabOne {

    private static String SEPARATOR = "--------------------------------------------------";
    private static String WELCOME = "Выберите часть лабы (1/2). Для выхода введите 'q'.";
    private static String PART_ONE = "1";
    private static String PART_TWO = "2";
    private static String QUIT = "q";
    private static String ERROR = "Ошибочный ввод";

    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);
        while (true) {
            System.out.println(SEPARATOR);
            System.out.println(WELCOME);
            String partNumber = in.nextLine();
            if (partNumber.equals(PART_ONE)) {
                (new PartOne()).run();
            } else if (partNumber.equals(PART_TWO)) {
                (new PartTwo()).run();
            } else if (partNumber.equals(QUIT)) {
                break;
            } else {
                System.out.println(ERROR);
            }
        }
    }
}