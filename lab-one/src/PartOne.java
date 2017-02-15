import java.util.*;
import java.util.function.Supplier;
import java.util.stream.Collectors;
import java.util.stream.IntStream;
import java.util.stream.Stream;

/**
 * Часть 1.
 * Дан массив A, длины N, дано целое число K. Надо циклически сдвинуть массив A на K элементов вправо. Если K отрицательно — сдвиг идет влево.
 * Например: A = [3, 2. 5, 9, 7], K = 3. Результат будет: [5, 9, 7, 3, 2].
 * <p>
 * Решение оформить в виде функции, которая принимает в качестве параметров массив и число K и возвращает сдвинутый массив.
 * <p>
 * N в интервале [0..100]. K в интервале [-100..100]. Каждый элемент массива A в интервале [1000..1000].
 */

public class PartOne {

    private static String WELCOME =
            "Выбрана первая часть. Выберите режим проверки: ручной(m) или автоматический(a). Для выхода введите 'q'.";
    private static String MANUALTEST = "m";
    private static String AUTOTEST = "a";
    private static String QUIT = "q";
    private static String ERROR = "Ошибочный ввод";

    private static String MANUALTEST_WElCOME =
            "Выбран ручной тест. Вводите числа разделяя их чем угодно, кроме '\\', этот символ будет означать конец ввода массива.";
    private static String MANUALTEST_WElCOME1 = "Введите количество ячеек, на которые нужно сдвинуть массив вправо.";

    private static String AUTOTEST_WElCOME = "Выбран автоматический тест.";
    private static String AUTOTEST_N = "Сгенерированный размер массива: ";
    private static String AUTOTEST_K = "Сгенерированный сдвиг массива: ";
    private static String AUTOTEST_ARRAY = "Сгенерированный массив: ";

    private static String SHUFFLED_ARRAY = "Сдвинутый массив: ";

    private static int UPPER_BOUND_N = 99;

    private static int UPPER_BOUND_K = 100;
    private static int LOWER_BOUND_K = -100;

    private static int UPPER_BOUND_ARRAY_ELEMENT = 1000;
    private static int LOWER_BOUND_ARRAY_ELEMENT = -1000;

    public PartOne() {
    }

    public void run() {
        Scanner in = new Scanner(System.in);

        System.out.println();
        System.out.println(WELCOME);

        while (true) {
            String partNumber = in.nextLine();
            if (partNumber.equals(MANUALTEST)) {
                manualTest();
            } else if (partNumber.equals(AUTOTEST)) {
                autoTest();
            } else if (partNumber.equals(QUIT)) {
                break;
            } else {
                System.out.println(ERROR);
            }
        }
    }

    private void manualTest() {
        System.out.println(MANUALTEST_WElCOME);
        Scanner in = new Scanner(System.in);
        List arr = new ArrayList();
        while (true) {
            String s = in.next();
            if (s.equals("\\")) {
                break;
            }
            arr.add(s);
        }
        System.out.println(MANUALTEST_WElCOME1);
        int k = in.nextInt();

        arr = shuffle(arr, k);
        System.out.println(SHUFFLED_ARRAY);
        arr.forEach(i -> System.out.print(i + " "));
        System.out.println();
    }

    private void autoTest() {
        Random random = new Random();
        int n = random.nextInt(UPPER_BOUND_N + 1);
        int k = random.nextInt(UPPER_BOUND_K - LOWER_BOUND_K) + LOWER_BOUND_K;
        List arr = (random.ints(n, LOWER_BOUND_ARRAY_ELEMENT, UPPER_BOUND_ARRAY_ELEMENT).boxed())
                .collect(Collectors.toList());

        System.out.println(AUTOTEST_WElCOME);
        System.out.println(AUTOTEST_N + n);
        System.out.println(AUTOTEST_K + k);

        System.out.println(AUTOTEST_ARRAY);
        arr.forEach(i -> System.out.print(i + " "));
        System.out.println();

        arr = shuffle(arr, k);

        System.out.println(SHUFFLED_ARRAY);
        arr.forEach(i -> System.out.print(i + " "));
        System.out.println();
    }

    public List shuffle(List arr, int k) {
        int n = arr.size();

        if (k == 0) {
            return new ArrayList(arr);
        }

        if (Math.abs(k) > n) {
            k = k % n;
        }
        if (Math.abs(k) > n / 2) {
            k = -(n - Math.abs(k));
        }

        List result = new ArrayList(n);
        if (k > 0) {
            for (int i = n - k; i < n; i++) {
                result.add(arr.get(i));
            }
            for (int i = 0; i < k; i++) {
                result.add(arr.get(i));
            }
        } else {
            k = -k;
            for (int i = k; i < n - k; i++) {
                result.add(arr.get(i));
            }
            for (int i = 0; i < k; i++) {
                result.add(arr.get(i));
            }
        }
        return result;
    }
}
