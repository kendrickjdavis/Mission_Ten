import logo from "./ball1.png";

function Header(props: any) {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo"></img>
      </div>
      <div className="col subtitle">
        <h1 className="text-white">{props.title}</h1>
        <h5 className="text-white">Welcome to our site!</h5>
        <br></br>
        <h5 className="text-white">
          Competition for being the best bowler is fierce! We want you to know
          who you are up against. We have conveniently listed the players from
          the Marlins and Sharks. Best of luck! May your ball travel swiftly.
        </h5>
      </div>
    </header>
  );
}

export default Header;
