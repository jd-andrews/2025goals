body {
  margin: 0;
  height: 100vh;
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  grid-template-rows: 0.25fr repeat(5, 1fr);
  grid-column-gap: 0px;
  grid-row-gap: 0px;
  font-family: monospace;
  font-size: 2.5vw;
  background: linear-gradient(-45deg, #444d49, #66736d, #b1bab6, #8b9892);
  background-size: 400% 400%;
  animation: infiniwaves 15s ease infinite;
}

header {
  grid-area: 1 / 1 / 2 / 3;
}

ul {
  list-style-type: square;
}

.div2 {
  grid-area: 2 / 1 / 3 / 2;
}
.div3 {
  grid-area: 2 / 2 / 3 / 3;
}
.div4 {
  grid-area: 3 / 1 / 4 / 2;
}
.div5 {
  grid-area: 3 / 2 / 4 / 3;
}
.div6 {
  grid-area: 4 / 1 / 5 / 2;
}
.div7 {
  grid-area: 4 / 2 / 5 / 3;
}
.div8 {
  grid-area: 5 / 1 / 6 / 2;
}
.div9 {
  grid-area: 5 / 2 / 6 / 3;
}
.resolutions {
  border: 2px solid black;
  padding: 20px;
  margin: 20px;
  /* border-radius: 5px; */
}

p,
h1,
h2 {
  text-align: center;
}

@keyframes infiniwaves {
  0% {
    background-position: 0% 50%;
  }
  50% {
    background-position: 100% 50%;
  }
  100% {
    background-position: 0% 50%;
  }
}

@media screen and (min-width: 768px) {
  #timetime {
    flex-direction: row;
    justify-content: space-evenly;
  }
}

@media (max-width: 777px) {
  body {
    grid-template-columns: 1fr;
    grid-template-rows: 0.25fr repeat(6, 1fr);
    font-size: 5vw;
  }

  header {
    grid-area: 1 / 1 / 2 / 2;
  }
  .div2 {
    grid-area: 2 / 1 / 3 / 2;
  }
  .div3 {
    grid-area: 3 / 1 / 4 / 2;
  }
  .div4 {
    grid-area: 4 / 1 / 5 / 2;
  }
  .div5 {
    grid-area: 5 / 1 / 6 / 2;
  }
  .div6 {
    grid-area: 6 / 1 / 7 / 2;
  }
  .div7 {
    grid-area: 7 / 1 / 8 / 2;
  }
}
