<?php
session_start();
require_once 'db.php';

header('Content-Type: application/json');

$response = ['status' => 'error', 'message' => ''];

// Проверяем метод запроса
if ($_SERVER['REQUEST_METHOD'] !== 'POST') {
    $response['message'] = 'Неверный метод запроса';
    echo json_encode($response);
    exit;
}

// Получаем данные из формы
$email = trim($_POST['email'] ?? '');
$password = $_POST['password'] ?? '';

// Проверяем, что все поля заполнены
if (empty($email) || empty($password)) {
    $response['message'] = 'Все поля обязательны для заполнения';
    echo json_encode($response);
    exit;
}

// Проверяем формат email
if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
    $response['message'] = 'Некорректный email';
    echo json_encode($response);
    exit;
}

try {
    // Ищем пользователя в базе данных
    $stmt = $conn->prepare("SELECT id, name, email, password FROM users WHERE email = ?");
    $stmt->bind_param("s", $email);
    $stmt->execute();
    $result = $stmt->get_result();
    
    // Если пользователь не найден
    if ($result->num_rows === 0) {
        $response['message'] = 'Пользователь с таким email не найден';
        echo json_encode($response);
        exit;
    }

    $user = $result->fetch_assoc();
    
    // Проверяем пароль
    if (!password_verify($password, $user['password'])) {
        $response['message'] = 'Неверный пароль';
        echo json_encode($response);
        exit;
    }

    // Создаем сессию пользователя
    $_SESSION['user'] = [
        'id' => $user['id'],
        'name' => $user['name'],
        'email' => $user['email'],
        'authenticated' => true
    ];

    $response['status'] = 'success';
    $response['message'] = 'Авторизация прошла успешно';
    $response['redirect'] = 'profile.php';
    echo json_encode($response);
    
} catch(Exception $e) {
    $response['message'] = 'Ошибка при авторизации: ' . $e->getMessage();
    echo json_encode($response);
}
?>