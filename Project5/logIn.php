<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Авторизация</title>
    <link rel="stylesheet" href="/styleLog.css">
</head>
<body>
    <div class="wrapper">
        <header>
            <nav>
                <ul>
                    <li><a href="/indexP.php">Главная</a></li>
                    <li><a href="/faq.php">О нас</a></li>
                    <li><a href="/kabinet.php">Личный Кабинет</a></li>
                    <li><a href="/kabinetAdm.php">Админ Кабинет</a></li>
                </ul>
            </nav>
        </header>

        <main>
            <div class="container">
                <h1>Авторизация</h1>
                <p>Введите ваши учетные данные</p>

                <form id="loginForm" action="/loginDb.php" method="post">
                    <div class="input-group">
                        <label for="email">Адрес электронной почты</label>
                        <input type="email" id="email" name="email" placeholder="Введите адрес электронной почты" required>
                    </div>

                    <div class="input-group">
                        <label for="password">Пароль</label>
                        <input type="password" id="password" name="password" placeholder="Введите пароль" required>
                    </div>

                    <button type="submit">Войти</button>

                    <p>Нет аккаунта? <a href="/register.php">Зарегистрироваться</a></p>
                </form>
            </div>
        </main>
    </div>

    <script>
        document.getElementById('loginForm').addEventListener('submit', function(e) {
            e.preventDefault();
            
            const form = e.target;
            const formData = new FormData(form);
            
            fetch(form.action, {
                method: 'POST',
                body: formData
            })
            .then(response => response.json())
            .then(data => {
                if (data.status === 'success') {
                    window.location.href = '/kabinet.php'; // Перенаправление в личный кабинет
                } else {
                    alert(data.message);
                }
            })
            .catch(error => {
                console.error('Error:', error);
                alert('Произошла ошибка при авторизации');
            });
        });
    </script>
</body>
</html>