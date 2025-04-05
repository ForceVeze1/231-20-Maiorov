<?php
require 'db.php';

header('Content-Type: application/json');

$response = ['status' => 'error', 'message' => ''];

if ($_SERVER['REQUEST_METHOD'] !== 'POST') {
    $response['message'] = 'Неверный метод запроса';
    echo json_encode($response);
    exit;
}

// Получаем данные из формы
$name = trim($_POST['name'] ?? '');
$email = trim($_POST['email'] ?? '');
$password = $_POST['password'] ?? '';
$repeat_password = $_POST['repeat_password'] ?? '';
$privacy_policy = isset($_POST['privacy_policy']);

// Валидация
if (empty($name) || empty($email) || empty($password) || empty($repeat_password)) {
    $response['message'] = 'Все поля обязательны для заполнения';
    echo json_encode($response);
    exit;
}

if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
    $response['message'] = 'Некорректный email';
    echo json_encode($response);
    exit;
}

if (strlen($password) < 6) {
    $response['message'] = 'Пароль должен содержать минимум 6 символов';
    echo json_encode($response);
    exit;
}

if ($password !== $repeat_password) {
    $response['message'] = 'Пароли не совпадают';
    echo json_encode($response);
    exit;
}

if (!$privacy_policy) {
    $response['message'] = 'Необходимо согласие с политикой обработки данных';
    echo json_encode($response);
    exit;
}

try {
    // Проверка существования пользователя
    $stmt = $conn->prepare("SELECT id FROM users WHERE email = ?");
    $stmt->bind_param("s", $email);
    $stmt->execute();
    $stmt->store_result();
    
    if ($stmt->num_rows > 0) {
        $response['message'] = 'Пользователь с таким email уже существует';
        echo json_encode($response);
        exit;
    }

    // Регистрация нового пользователя
    $hashedPassword = password_hash($password, PASSWORD_DEFAULT);
    $stmt = $conn->prepare("INSERT INTO users (name, email, password) VALUES (?, ?, ?)");
    $stmt->bind_param("sss", $name, $email, $hashedPassword);
    $stmt->execute();

    $response['status'] = 'success';
    $response['message'] = 'Регистрация прошла успешно';
    echo json_encode($response);
    
} catch(Exception $e) {
    $response['message'] = 'Ошибка при регистрации: ' . $e->getMessage();
    echo json_encode($response);
}
?>