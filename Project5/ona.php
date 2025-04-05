<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>До свидания!</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: linear-gradient(135deg, #f5f7fa 0%, #c3cfe2 100%);
            margin: 0;
            padding: 0;
            height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
            color: #333;
        }
        
        .goodbye-container {
            text-align: center;
            max-width: 500px;
            padding: 40px;
            background: white;
            border-radius: 20px;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
            animation: fadeIn 0.8s ease-out;
        }
        
        h1 {
            color: #4a4a4a;
            margin-bottom: 20px;
            font-size: 2.2em;
        }
        
        p {
            font-size: 1.1em;
            line-height: 1.6;
            margin-bottom: 30px;
            color: #666;
        }
        
        .emoji {
            font-size: 3.5rem;
            margin-bottom: 20px;
            display: inline-block;
            animation: wave 2s infinite;
        }
        
        .btn {
            display: inline-block;
            padding: 12px 30px;
            background: #4a6bff;
            color: white;
            text-decoration: none;
            border-radius: 50px;
            font-weight: 600;
            transition: all 0.3s ease;
            border: none;
            cursor: pointer;
            font-size: 1em;
            margin: 10px;
            box-shadow: 0 4px 15px rgba(74, 107, 255, 0.3);
        }
        
        .btn:hover {
            background: #3a5bef;
            transform: translateY(-3px);
            box-shadow: 0 6px 20px rgba(74, 107, 255, 0.4);
        }
        
        .btn-outline {
            background: transparent;
            border: 2px solid #4a6bff;
            color: #4a6bff;
        }
        
        .btn-outline:hover {
            background: #f0f4ff;
        }
        
        @keyframes fadeIn {
            from { opacity: 0; transform: translateY(20px); }
            to { opacity: 1; transform: translateY(0); }
        }
        
        @keyframes wave {
            0%, 100% { transform: rotate(0deg); }
            25% { transform: rotate(10deg); }
            75% { transform: rotate(-10deg); }
        }
        
        .footer {
            margin-top: 40px;
            font-size: 0.9em;
            color: #999;
        }
    </style>
</head>
<body>
    <div class="goodbye-container">
        <div class="emoji">👋</div>
        <h1>До скорой встречи!</h1>
        <p>Спасибо, что посетили наш сайт. Мы будем рады видеть вас снова!</p>
        <p>Если вы вышли случайно, вы можете вернуться обратно.</p>
        
        <div class="buttons">
            <a href="IndexP.php" class="btn">
                <i class="fas fa-home"></i> Вернуться на главную
            </a>
            <a href="login.php" class="btn btn-outline">
                <i class="fas fa-sign-in-alt"></i> Войти снова
            </a>
        </div>
        
        <div class="footer">
            <p>© 2025  MetaSpace. Все права защищены.</p>
        </div>
    </div>
</body>
</html>