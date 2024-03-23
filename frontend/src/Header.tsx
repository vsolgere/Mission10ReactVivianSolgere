function Header(props: any) {
  return (
    <header className="row">
      <div className="col-4">
        <h2>{props.title}</h2>
      </div>
    </header>
  );
}

export default Header;
