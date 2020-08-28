const $btn1 = document.getElementById("btn-kick1");
const $btn2 = document.getElementById("btn-kick2");
const character = {
  name: "Pikachu",
  defaultHP: 100,
  damageHP: 100,
  elHP: document.getElementById("health-character"),
  elProgressbar: document.getElementById("progressbar-character"),
};
const enemy = {
  name: "Charmander",
  defaultHP: 100,
  damageHP: 100,
  elHP: document.getElementById("health-enemy"),
  elProgressbar: document.getElementById("progressbar-enemy"),
};
$btn1.addEventListener("click", function () {
  console.log("Kick");
  changeHPBoth(random(30), random(40), character, enemy);
});
$btn2.addEventListener("click", function () {
  console.log("KickEnemy");
  changeHPOne(random(30), enemy);
});
function init() {
  console.log("Start game");
  random();
  renderHP(character);
  renderHP(enemy);
}
function renderHP(person) {
  renderHPLife(person);
  renderProgressbarHP(person);
}
function renderHPLife(person) {
  person.elHP.innerText = person.damageHP + " / " + person.defaultHP;
}
function renderProgressbarHP(person) {
  person.elProgressbar.style.width = person.damageHP + "%";
}
function changeHPBoth(count1, count2, person, enemy) {
  if (person.damageHP < count1) {
    person.damageHP = 0;
    alert("Бедный " + person.name + " проиграл бой");
    $btn1.disabled = true;
    $btn2.disabled = true;
  } else {
    person.damageHP -= count1;
  }
  if (enemy.damageHP < count2) {
    enemy.damageHP = 0;
    alert("Бедный " + enemy.name + " проиграл бой");
    $btn2.disabled = true;
    $btn1.disabled = true;
  } else {
    enemy.damageHP -= count2;
  }
  renderHP(person);
  renderHP(enemy);
}
function changeHPOne(count, enemy) {
  if (enemy.damageHP < count) {
    enemy.damageHP = 0;
    alert("Бедный " + enemy.name + " проиграл бой");
    $btn2.disabled = true;
    $btn1.disabled = true;
  } else enemy.damageHP -= count;
  renderHP(enemy);
}
function random(num) {
  return Math.ceil(Math.random() * num);
}
init();
