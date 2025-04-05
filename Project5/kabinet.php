<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Личный кабинет</title>
    <link rel="stylesheet" href="kabinet.css">
</head>
<body>
    <div class="container">
        <header>
            <h1>Личный кабинет</h1>
            <nav>
                <ul>
                    <li><a href="indexP.php">Главная</a></li>
                    <li><a href="faq.php">О нас</a></li>
                    <li><a href="ona.php">Выйти</a></li>
                    <li><a href="kabinetAdm.php">Админка</a></li>
                </ul>
            </nav>
        </header>
        <main>
            <section class="profile">
                <h2>Профиль пользователя</h2>
                <div class="profile-info">
                    
                    <div class="details">
                        <p><strong>Имя:</strong> Иван Иванов</p>
                        <p><strong>Email:</strong> ivan@example.com</p>
                        <p><strong>Телефон:</strong> +7 (123) 456-78-90</p>
                    </div>
                </div>
            </section>
            <section class="settings">
                <h2>Настройки</h2>
                <form>
                    <label for="username">Имя пользователя:</label>
                    <input type="text" id="username" name="username" value="Иван Иванов">
                    <label for="email">Email:</label>
                    <input type="email" id="email" name="email" value="ivan@example.com">
                    <label for="phone">Телефон:</label>
                    <input type="tel" id="phone" name="phone" value="+7 (123) 456-78-90">
                    <button type="submit">Сохранить изменения</button>
                </form>
            </section>
        </main>
        <footer>
            <p>&copy; 2023 Личный кабинет. Все права защищены MetaSpace.</p>
        </footer>
    </div>
</body>
</html>
