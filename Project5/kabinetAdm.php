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
                </ul>
            </nav>
        </header>
        <main>
        <section class="profile">
                <h2>Профиль Администратора</h2>
                <div class="profile-info">
                    
                    <div class="details">
                        <p><strong>Имя:</strong> Cлава Венедиктов</p>
                        <p><strong>Email:</strong> slava@example.com</p>
                        <p><strong>Телефон:</strong> +7 (123) 666-66-66</p>
                    </div>
                </div>
                
            
            </section>






            <section class="settings">
            <!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Личный кабинет</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css">
    <style>
        .user-list {
            display: grid;
            grid-template-columns: repeat(auto-fill, minmax(280px, 1fr));
            gap: 20px;
            padding: 0;
            list-style: none;
        }
        
        .user-card {
            background: #fff;
            border-radius: 12px;
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.1);
            padding: 20px;
            display: flex;
            align-items: center;
            transition: transform 0.3s ease;
        }
        
        .user-card:hover {
            transform: translateY(-5px);
        }
        
        .avatar {
            width: 60px;
            height: 60px;
            border-radius: 50%;
            object-fit: cover;
            margin-right: 15px;
            border: 3px solid #e0e0e0;
        }
        
        .user-info {
            flex: 1;
        }
        
        .username {
            font-weight: 600;
            margin: 0 0 5px 0;
            color: #333;
        }
        
        .nickname {
            color: #666;
            font-size: 0.9em;
            margin: 0 0 5px 0;
        }
        
        .contact {
            font-size: 0.8em;
            color: #888;
            margin: 3px 0;
            display: flex;
            align-items: center;
        }
        
        .contact i {
            margin-right: 5px;
            width: 16px;
            text-align: center;
        }
        
        .status {
            display: inline-block;
            width: 10px;
            height: 10px;
            border-radius: 50%;
            margin-left: 5px;
        }
        
        .online {
            background-color: #4CAF50;
        }
        
        .offline {
            background-color: #9E9E9E;
        }
    </style>
</head>
<body>
    <div class="container">
        <!-- ... остальной код header и профиля ... -->
        
        <section class="settings">
            <h2>Список Пользователей</h2>
            <ul class="user-list">
                <li class="user-card">
                    <img src="https://randomuser.me/api/portraits/men/1.jpg" alt="Алексей Петров" class="avatar">
                    <div class="user-info">
                        <h3 class="username">Алексей Петров <span class="status online"></span></h3>
                        <p class="nickname">@alex_petrov</p>
                        <p class="contact"><i class="fas fa-envelope"></i> alex@example.com</p>
                        <p class="contact"><i class="fas fa-phone"></i> +7 (987) 654-32-10</p>
                    </div>
                </li>
                
                <li class="user-card">
                    <img src="https://randomuser.me/api/portraits/women/2.jpg" alt="Екатерина Смирнова" class="avatar">
                    <div class="user-info">
                        <h3 class="username">Екатерина Смирнова <span class="status online"></span></h3>
                        <p class="nickname">@kate_smirnova</p>
                        <p class="contact"><i class="fas fa-envelope"></i> ekaterina@example.com</p>
                        <p class="contact"><i class="fas fa-phone"></i> +7 (916) 123-45-67</p>
                    </div>
                </li>
                
                <li class="user-card">
                    <img src="https://randomuser.me/api/portraits/men/3.jpg" alt="Дмитрий Иванов" class="avatar">
                    <div class="user-info">
                        <h3 class="username">Дмитрий Иванов <span class="status offline"></span></h3>
                        <p class="nickname">@dima_ivanov</p>
                        <p class="contact"><i class="fas fa-envelope"></i> dmitry@example.com</p>
                        <p class="contact"><i class="fas fa-phone"></i> +7 (903) 456-78-90</p>
                    </div>
                </li>
                
                <li class="user-card">
                    <img src="https://randomuser.me/api/portraits/women/4.jpg" alt="Ольга Кузнецова" class="avatar">
                    <div class="user-info">
                        <h3 class="username">Ольга Кузнецова <span class="status online"></span></h3>
                        <p class="nickname">@olga_kuz</p>
                        <p class="contact"><i class="fas fa-envelope"></i> olga@example.com</p>
                        <p class="contact"><i class="fas fa-phone"></i> +7 (925) 111-22-33</p>
                    </div>
                </li>
                
                <li class="user-card">
                    <img src="https://randomuser.me/api/portraits/men/5.jpg" alt="Михаил Соколов" class="avatar">
                    <div class="user-info">
                        <h3 class="username">Михаил Соколов <span class="status online"></span></h3>
                        <p class="nickname">@misha_sokol</p>
                        <p class="contact"><i class="fas fa-envelope"></i> mikhail@example.com</p>
                        <p class="contact"><i class="fas fa-phone"></i> +7 (926) 444-55-66</p>
                    </div>
                </li>
                
                <li class="user-card">
                    <img src="https://randomuser.me/api/portraits/women/6.jpg" alt="Анна Попова" class="avatar">
                    <div class="user-info">
                        <h3 class="username">Анна Попова <span class="status offline"></span></h3>
                        <p class="nickname">@anna_pop</p>
                        <p class="contact"><i class="fas fa-envelope"></i> anna@example.com</p>
                        <p class="contact"><i class="fas fa-phone"></i> +7 (917) 777-88-99</p>
                    </div>
                </li>
                
                <li class="user-card">
                    <img src="https://randomuser.me/api/portraits/men/7.jpg" alt="Сергей Лебедев" class="avatar">
                    <div class="user-info">
                        <h3 class="username">Сергей Лебедев <span class="status online"></span></h3>
                        <p class="nickname">@serg_lebed</p>
                        <p class="contact"><i class="fas fa-envelope"></i> sergey@example.com</p>
                        <p class="contact"><i class="fas fa-phone"></i> +7 (919) 000-11-22</p>
                    </div>
                </li>
                
                <li class="user-card">
                    <img src="https://randomuser.me/api/portraits/women/8.jpg" alt="Наталья Козлова" class="avatar">
                    <div class="user-info">
                        <h3 class="username">Наталья Козлова <span class="status offline"></span></h3>
                        <p class="nickname">@nata_koz</p>
                        <p class="contact"><i class="fas fa-envelope"></i> natalia@example.com</p>
                        <p class="contact"><i class="fas fa-phone"></i> +7 (918) 333-44-55</p>
                    </div>
                </li>
                
                <li class="user-card">
                    <img src="https://randomuser.me/api/portraits/men/9.jpg" alt="Андрей Новиков" class="avatar">
                    <div class="user-info">
                        <h3 class="username">Андрей Новиков <span class="status online"></span></h3>
                        <p class="nickname">@andrey_nov</p>
                        <p class="contact"><i class="fas fa-envelope"></i> andrey@example.com</p>
                        <p class="contact"><i class="fas fa-phone"></i> +7 (915) 666-77-88</p>
                    </div>
                </li>
                
                
            </ul>
        </section>
        
        <!-- ... остальной код ... -->
    </div>

            </section>
        </main>
        <footer>
            <p>&copy; 2023 Личный кабинет. Все права защищены MetaSpace.</p>
        </footer>
    </div>
</body>
</html>
