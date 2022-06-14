* {
  box-sizing: border-box;
  padding: 0;
  margin: 0 auto;
}

body {
  background-color: #f3f3f3;
  margin: 0 auto;
}

li {
  list-style: none;
}

a {
  text-decoration: none;
  color: black;
}

svg {
  width: 19px;
  margin: 0;
}

img {
  object-fit: cover;
  object-position: center;
}

.icon {
  width: 15px;
  margin: 0 10px -3px 0;
}

body {
  font-family: roboto, san-serif;
  font-size: 16px;
  font-weight: 300;
  min-width: 380px;
  width: 100%;
}

.container__title h1 {
  font-family: shrikhand, serif;
  font-style: italic;
  letter-spacing: 1px;
  margin: 0px 15px;
  text-transform: capitalize;
}

h3 {
  text-transform: capitalize;
  margin: 3px 0;
}

.uppercase {
  text-transform: uppercase;
  font-weight: 300;
  padding: 0 5px;
  font-size: 1.07rem;
  position: relative;
  margin-bottom: 10px;
}
.uppercase:after {
  content: "";
  width: 50px;
  height: 3px;
  background-color: #99e2d0;
  left: 5px;
  bottom: -6px;
  position: absolute;
}

.lowercase {
  text-transform: lowercase;
}

@media only screen and (min-width: 768px) {
  body h1 {
    font-size: 2.5rem;
  }
  body .uppercase,
body h3 {
    font-size: 1.3rem;
  }
  body p {
    font-size: 1.15rem;
  }
}
.container__menu__simple__card__transform {
  width: 100%;
  height: 70px;
}
.container__menu__simple__card:hover .container__menu__simple__card__transform {
  width: 82%;
  margin-left: 0;
  border-top-right-radius: 0;
  border-bottom-right-radius: 0;
  position: relative;
}
.container__menu__simple__card:hover .tertiary {
  transform: translateX(-100%);
}
.container__menu__simple__card:hover svg {
  transform: rotate(-360deg);
}
.container__menu__simple__card .tertiary {
  width: 18%;
  height: 100%;
  margin: 0;
  position: absolute;
  right: -18%;
  transition: transform 400ms ease;
}
.container__menu__simple__card .tertiary svg {
  transition: transform 800ms ease;
}

.loadingCard--1 {
  animation: loadingCard 500ms ease-out forwards;
  border-radius: 15px;
}
.loadingCard--2 {
  animation: loadingCard 900ms ease-out forwards;
  border-radius: 15px;
}
.loadingCard--3 {
  animation: loadingCard 1300ms ease-out forwards;
  border-radius: 15px;
}

.loadingGroup--1 {
  animation: loadingCard 1000ms cubic-bezier(0, 0.69, 0, 1) 100ms;
}
.loadingGroup--2 {
  animation: loadingCard 1000ms ease-in-out 100ms;
}
.loadingGroup--3 {
  animation: loadingCard 1000ms cubic-bezier(0.5, -0.06, 0.53, 0.29) 100ms;
}

@keyframes loadingCard {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}
@keyframes loader {
  0% {
    opacity: 0;
  }
  20%, 80% {
    opacity: 1;
  }
  100% {
    opacity: 0;
    visibility: hidden;
  }
}
@keyframes dot-scale {
  0%, 30% {
    transform: scale(1.1);
  }
  37% {
    transform: scale(1.45);
  }
  40%, 100% {
    transform: scale(1.5);
  }
}
@keyframes letter-opacity {
  0% {
    opacity: 0;
  }
  50%, 100% {
    opacity: 1;
  }
}
@keyframes icon-opacity {
  0% {
    opacity: 1;
  }
  50%, 100% {
    opacity: 0;
  }
}
.banner {
  display: none;
}

@media only screen and (min-width: 1024px) {
  .banner {
    display: flex;
    background-color: silver;
  }
  .banner__group {
    border: 2px dashed blue;
    margin: 15px;
    height: 100%;
    width: 100%;
  }
  .banner__group figure {
    border: 2px dashed red;
    border-radius: 15px;
    height: 80%;
    background-color: #000002;
    background-color: orange;
    position: relative;
  }
  .banner__group figure img {
    object-fit: contain;
    width: 100%;
    height: 80%;
  }
  .banner__group figure figcaption {
    color: white;
    position: absolute;
    bottom: 10px;
  }
  .banner__group figure .banner__group figure h1 {
    font-size: 4rem;
    background-color: orange;
    left: 60px;
    top: 60px;
  }
  .banner__group figure p {
    font-size: 2rem;
    background-color: lightblue;
    left: 20px;
    top: 20px;
  }
}
.btn {
  cursor: pointer;
}

.primary {
  height: 50px;
  width: 220px;
  border-radius: 50px;
  color: white;
  display: flex;
  justify-content: center;
  align-items: center;
  margin: 20px auto 30px;
  letter-spacing: 0.5px;
  padding: 0 15px;
}
.primary:active {
  transform: translate(1px, 1px);
}

.secondary {
  border: 2px dashed red;
  border: none;
  display: flex;
  position: relative;
  width: 50px;
  height: 50px;
  background-color: transparent;
}
.secondary svg {
  width: 25px;
}
.secondary__line, .secondary__solid {
  margin: 0;
  position: absolute;
  bottom: 15px;
}
.secondary__solid {
  right: 10000px;
}
.secondary__line {
  right: 10px;
}
.secondary:active {
  transform: translate(2px, 2px);
}
.secondary:focus .secondary__solid {
  right: 10px;
}

.tertiary {
  border: none;
  position: relative;
  width: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
}
.tertiary svg {
  position: absolute;
}
.tertiary:active svg {
  transform: translate(1px, 1px);
}

.container__menu {
  border: 2px dashed darkcyan;
  padding: 20px;
}
.container__menu__full {
  border: 2px dashed cyan;
  width: 100%;
  min-width: 350px;
}
.container__menu__full figure {
  width: 100%;
  background-color: white;
  height: 100%;
  position: relative;
}
.container__menu__full figure img {
  width: 100%;
  height: 73%;
}
.container__menu__full figure span {
  position: absolute;
  display: flex;
  top: 6%;
  right: 3%;
  width: 75px;
  height: 30px;
  background-color: cyan;
  justify-content: center;
  align-items: center;
  padding: 2px;
  font-weight: 700;
  font-size: 0.8rem;
  color: blue;
  border-radius: 3px;
}
.container__menu__full figure figcaption {
  background-color: white;
  margin: 7px 12px;
  width: 80%;
}
.container__menu__simple {
  width: 100%;
  margin: 15px 0;
  height: 70px;
}
.container__menu__simple__card {
  margin: 15px 0;
  display: flex;
  position: relative;
  overflow: hidden;
}
.container__menu__simple__card__static {
  width: 100%;
  height: 70px;
  justify-content: flex-end;
  position: absolute;
  display: flex;
  margin: 0 !important;
  right: 0;
}
.container__menu__simple__card__static svg {
  padding: 5px;
  width: 22px;
}
.container__menu__simple__card__transform {
  background-color: white;
  margin: 0 !important;
  padding: 10px;
  z-index: 1;
}
.container__menu__simple__card__transform__text {
  margin: 0;
}
.container__menu__simple__card__transform__text__subText {
  display: flex;
  margin: 0;
  justify-content: space-between;
}
.container__menu__simple__card__transform__text__subText--bold {
  margin-right: 0;
  font-weight: 700;
}
.container__menu__simple__card__transform__text__subText p {
  margin-left: 0;
}

.container__menu__full {
  position: relative;
}
.container__menu__full .secondary {
  position: absolute;
  width: 50px;
  height: 50px;
  right: 2%;
  bottom: 16px;
}

@media only screen and (min-width: 768px) {
  .container__menu__simple__card__transform {
    padding: 10px;
  }
  .container__menu__simple__card__transform__subText {
    margin-bottom: 10px;
  }
}
@media only screen and (min-width: 768px) and (min-width: 1024px) {
  .container__menu {
    padding: 10px 20px;
  }
  .container__menu__simple {
    height: auto;
    display: flex;
    flex-direction: row;
    margin: 0;
    justify-content: space-between;
  }
  .container__menu__simple__card {
    flex-basis: 32%;
    margin: 0 auto;
  }
  .container__menu__simple__card__static {
    height: 140px;
  }
  .container__menu__simple__card__transform {
    height: 140px;
    text-align: center;
  }
  .container__menu__simple__card__transform__text {
    height: 100%;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
  }
  .container__menu__simple__card__transform__text h3 {
    margin: 2px auto;
    border-bottom: 3px solid #99e2d0;
    padding: 0 10px 5px;
  }
  .container__menu__simple__card__transform__text p {
    margin: 0 5px;
  }
  .container__menu__simple__card__transform__text__subText {
    flex-direction: column;
    height: 68%;
  }
  .container__menu__simple__card__transform__text__subText--bold {
    margin: 0;
  }
  .container__menu__simple__card__transform__text__subText p:nth-child(2) {
    margin-bottom: 0;
  }
  .container__menu__full {
    background-color: orange;
  }
}
main {
  display: flex;
  border: 4px dashed orange;
}

.mainRepeat {
  flex-direction: column;
}

.bgImage {
  width: 100%;
  max-height: 350px;
  height: 300px;
  order: 1;
}

.container {
  padding: 40px 20px 60px;
  margin-top: 30px;
  order: 2;
  width: 100%;
  max-width: 1500px;
}
.container__menu__simple {
  height: 100%;
}
.container__title {
  display: flex;
  justify-content: space-between;
  border: 2px dashed blue;
}
.container__title button {
  margin: 0;
}

@media only screen and (min-width: 768px) {
  .container {
    padding: 20px;
  }
  .container__menu {
    padding: 10px;
  }
  .container__menu__simple__card {
    margin: 20px 30px;
  }
  .container__menu__simple__card__transform__subText {
    margin-bottom: 10px;
  }
}
@media only screen and (min-width: 1024px) {
  .container__menu__simple__card {
    margin: 10px;
  }
}
.header {
  border: 3px dashed darkgrey;
}
.header__nav {
  display: flex;
  align-items: center;
  border: 3px dashed hotpink;
}
.header__nav__logo {
  margin: 15px auto;
  width: 250px;
  padding-right: 50px;
}
.header__nav a {
  margin-left: 20px;
}

.footer {
  padding: 25px 15px;
  letter-spacing: 0.5px;
}
.footer__logo {
  width: 120px;
  padding-left: 10px;
}
.footer__links li {
  margin: 10px;
}
.footer a {
  color: white;
}

.inverted {
  filter: invert(100%);
}

@media only screen and (min-width: 768px) {
  .footer {
    padding: 20px 20px 20px 40px;
  }
}
.header {
  text-align: center;
}
.header__logo {
  margin: 15px auto;
  width: 200px;
}
.header__search {
  background-color: #ececec;
  box-shadow: inset 0px 2px 5px 0px #8a8989;
}
.header__search form input {
  height: 60px;
  border: none;
  background-color: transparent;
  margin: 0;
  font-size: 1rem;
  font-weight: 700;
  text-align: center;
  width: 150px;
}
.header__search form input::placeholder {
  color: #505050;
}
.header__explore {
  padding: 10px 0;
}
.header__explore h2,
.header__explore p {
  max-width: 300px;
  margin: 30px auto;
  border: 2px dashed red;
}
.header__howItWorks {
  padding: 40px 15px;
  background-color: white;
  max-width: 1500px;
}
.header__howItWorks h2 {
  text-align: left;
  padding: 0 5px;
}
.header__howItWorks p {
  margin-left: 0;
}
.header__howItWorks__steps {
  display: flex;
  align-items: center;
  position: relative;
  font-weight: 700;
}
.header__howItWorks__steps svg {
  margin: 0 20px;
  fill: #686868;
}
.header__howItWorks__steps:hover {
  background-color: #f6e4fd;
  transform: scale(1.01);
  transition: 300ms ease-in-out;
}
.header__howItWorks__steps:hover svg {
  fill: #8559bb;
}
.header__howItWorks__steps:hover p {
  transition: 100ms ease-in-out;
  font-size: 1.07rem;
}

.reduce {
  width: 15px;
}

.circle {
  background-color: #8559bb;
  color: white;
  padding: 4px;
  margin: 0;
  width: 25px;
  height: 25px;
  position: absolute;
  left: -11px;
  font-weight: 300;
  font-size: 0.9rem;
  display: flex;
  justify-content: center;
}

@media only screen and (min-width: 768px) {
  .header__explore h2,
.header__explore p {
    max-width: 100%;
  }
  .header__howItWorks {
    padding: 40px 60px;
  }

  .containerIndex__menu {
    border: 2px dashed red;
  }
  .containerIndex__menu__full {
    max-width: 600px;
    padding: 5px;
  }
}
@media only screen and (min-width: 1024px) {
  .mainIndex {
    justify-content: space-around;
    width: 100%;
    margin: 0 auto;
  }

  .banner {
    flex-basis: 50%;
    margin: 15px;
    padding: 20px;
    border: 2px dashed blue;
  }

  .containerIndex {
    flex-basis: 50%;
  }
}
.loading {
  position: absolute;
  left: 0;
  margin: 0px auto;
  background: rgba(255, 255, 255, 0.9);
  display: flex;
  justify-content: center;
  align-items: center;
  z-index: 10;
  border: 5px dashed green;
  width: 100vw;
  height: 100%;
  animation: loader 300ms ease-in-out both;
}
.loading > * {
  margin: 15px;
  width: 40px;
  height: 40px;
  border-radius: 100px;
  display: flex;
  justify-content: center;
  align-items: center;
  position: relative;
  animation: dot-scale 4000ms ease infinite backwards;
}
.loading i {
  font-size: 20px;
  margin: 0px;
  position: absolute;
  animation-timing-function: linear;
  animation-iteration-count: infinite;
  animation-duration: 2000ms;
  animation-fill-mode: backwards;
}
.loading i:first-child {
  top: 9px;
  animation-name: letter-opacity;
}
.loading i:last-child {
  animation-name: icon-opacity;
}
.loading__l {
  animation-delay: 100ms;
  animation-duration: 1900ms;
}
.loading__o {
  animation-delay: 170ms;
  animation-duration: 1830ms;
}
.loading__a {
  animation-delay: 200ms;
  animation-duration: 1800ms;
}
.loading__d {
  animation-delay: 250ms;
  animation-duration: 1750ms;
}
.loading__i {
  animation-delay: 350ms;
  animation-duration: 1650ms;
}
.loading__n {
  animation-delay: 370ms;
  animation-duration: 1630ms;
}
.loading__g {
  animation-delay: 390ms;
  animation-duration: 1610ms;
}

card-full, .container__menu__full {
  border-radius: 15px;
  margin: 15px auto;
  text-transform: capitalize;
  height: 250px;
}
card-full img, .container__menu__full img {
  border-radius: 15px 15px 0 0;
}

card-simple, .container__menu__simple__card__transform {
  border-radius: 15px;
  margin: 15px auto;
}

card-steps, .header__howItWorks__steps {
  border-radius: 15px;
  margin: 15px auto;
  height: 70px;
  margin: 25px 10px 0 20px;
  padding-left: 10px;
}

border-radius, .container__menu__simple__card__static svg, .circle {
  border-radius: 15px;
}

border-radius-15, .tertiary, .container__menu__full figure, .container__menu__simple__card__static {
  border-radius: 15px;
}

border-right-radius-15 {
  border-radius: 0 15px 15px 0;
}

border-top-radius-25, .container {
  border-radius: 25px 25px 0 0;
}

.primary {
  background-image: linear-gradient(170deg, #FF79DA, #9356DC);
  filter: drop-shadow(3px 3px 3px #782cd3);
}

.secondary__line {
  fill: #9356DC;
}

.tertiary {
  background-color: #99e2d0;
}
.tertiary svg {
  background-color: white;
  fill: #99e2d0;
}
.tertiary:focus {
  background-color: #51e0bc;
}

.header__howItWorks__steps {
  background-color: #ebe9e9;
  filter: drop-shadow(3px 3px 3px #c7c1c1);
}

.footer {
  background-color: #353535;
}

.container {
  background-color: #ebe9e9;
}
.container__menu {
  background-color: #ebe9e9;
}
.container__menu__simple__card {
  filter: drop-shadow(5px 5px 5px #c7c1c1);
}
.container__menu__simple__card__static {
  background-color: #99e2d0;
}

.loading > * {
  background: linear-gradient(170deg, #FF79DA, #9356DC);
  color: white;
}

/*# sourceMappingURL=main.cs.map */