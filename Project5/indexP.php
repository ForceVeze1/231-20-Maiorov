<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Project6</title>

    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.7.1/css/all.min.css">
    
    <!-- box icons -->
    <link href='https://unpkg.com/boxicons@2.1.4/css/boxicons.min.css' rel='stylesheet'>

</head>

<body>

<!-- head design -->

    <header class="header">
        <a href="#" class="logo">MetaSpace </a>

        <nav class="navbar">
            <a href="faq.php">О нас</a>
            <a href="registor.php">Зарегистрироваться</a>
            <a href="logIn.php" class="active">Войти</a>

            <span class="active-nav"></span>
        </nav>
    </header>

     <!-- home section design --> 
     <section class="home show-animate" id="home">
        <div class="home-content">
            <h1>Качественный сервис по созданию  <span>опросов</span>
            </h1>
            <p> Создай квиз опрос за 10 минут самостоятельно без дизайнера и программиста. </p>
            <div class="btn-box">
                <a href="logIn.php" class="btn">Войти</a>
            </div>
        </div>

        <!-- <div class="home-imgHover">
            <img src="img/graph1.png" alt="">
        </div> -->
        
        <div class="blockSlider" id="blockSlider">
            <div class="fullArea">
                <div class="imagesArea">
                    <img class="imageSlider" src="img/opr1.jpg" alt="">
                    
                </div>

                <div class="pointsAreaSize">
                    <span class="point"></span>
                    
                </div>

                
            </div>
        </div>


        

        <script src="app.js"></script>
     </section>
     <!-- Отзывы пользователей -->
<section class="reviews-section">
    <h2>Отзывы наших пользователей</h2>
    <div class="review-card">
        <h3>Алексей Иванов</h3>
        <div class="rating">★★★★★</div>
        <p>Очень удобный сервис! Создал опрос за считанные минуты. Все интуитивно понятно, даже для новичка. Рекомендую!</p>
    </div>
    <div class="review-card">
        <h3>Мария Петрова</h3>
        <div class="rating">★★★★☆</div>
        <p>Отличный инструмент для сбора данных. Единственное, хотелось бы больше шаблонов для оформления.</p>
    </div>
    <div class="review-card">
        <h3>Дмитрий Сидоров</h3>
        <div class="rating">★★★★★</div>
        <p>Спасибо за такой простой и функциональный сервис. Использую его для проведения опросов в своей компании.</p>
    </div>
</section>

<script src="app.js"></script>
</body>
</html>


</body>
</html>