<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Регистрация</title>
    <link rel="stylesheet" href="/styleReg.css">
</head>
<body>
    <div class="wrapper">
        <header>
            <nav>
                <ul>
                    <li><a href="/indexP.php">Главная</a></li>
                    <li><a href="/faq.php">О нас</a></li>
                </ul>
            </nav>
        </header>

        <main>
            <div class="container">
                <h1>Регистрация</h1>
                <p>Создайте новый аккаунт.</p>

                <form id="registrationForm" action="/registerDb.php" method="post">
                    <div class="input-group">
                        <label for="name">Введите ваше имя</label>
                        <input type="text" id="name" name="name" placeholder="Введите ваше имя" required>
                    </div>
            
                    <div class="input-group">
                        <label for="email">Адрес электронной почты</label>
                        <input type="email" id="email" name="email" placeholder="Введите адрес электронной почты" required>
                    </div>
            
                    <div class="input-group">
                        <label for="password">Пароль</label>
                        <input type="password" id="password" name="password" placeholder="Введите пароль" minlength="6" required>
                        <small>Пароль должен содержать не менее 6 символов</small>
                    </div>
            
                    <div class="input-group">
                        <label for="repeat_password">Повторите пароль</label>
                        <input type="password" id="repeat_password" name="repeat_password" placeholder="Повторите пароль" required>
                    </div>

                    <div class="checkbox-group">
                        <input type="checkbox" id="privacy_policy" name="privacy_policy" required>
                        <label for="privacy_policy">
                            Согласие с <a href="/policy.pdf" target="_blank">политикой обработки персональных данных</a>
                        </label>
                    </div>

                    <button type="submit">Зарегистрироваться</button>
                    
                    <div class="login-link">
                        <p>Уже есть аккаунт? <a href="/login.php">Войти</a></p>
                    </div>
                </form>
            </div>
        </main>
    </div>
        
    <script>
        document.getElementById('registrationForm').addEventListener('submit', function(e) {
            e.preventDefault();
            
            const form = e.target;
            const formData = new FormData(form);
            
            // Проверка паролей
            const password = document.getElementById('password').value;
            const repeatPassword = document.getElementById('repeat_password').value;
            
            if (password !== repeatPassword) {
                alert('Пароли не совпадают!');
                return false;
            }
            
            // Отправка формы
            fetch(form.action, {
                method: 'POST',
                body: formData
            })
            .then(response => response.json())
            .then(data => {
                if (data.status === 'success') {
                    alert(data.message);
                    window.location.href = '/login.php'; // Перенаправление на страницу входа
                } else {
                    alert(data.message);
                }
            })
            .catch(error => {
                console.error('Error:', error);
                alert('Произошла ошибка при регистрации');
            });
        });
    </script>
</body>
</html>