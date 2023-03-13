import React, { useState, useEffect } from 'react';

function ServiceCard({ title, image, description, contact }) {
  return (
    <div className="card">
      <img src={image} className="card-img-top" alt={title} />
      <div className="card-body">
        <h5 className="card-title">{title}</h5>
        <p className="card-text">{description}</p>
        <p className="card-text">{contact}</p>
      </div>
    </div>
  );
}

function ServiceList() {
  const [services, setServices] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    async function fetchServices() {
      const response = await fetch('https://example.com/services');
      const data = await response.json();
      setServices(data);
      setLoading(false);
    }
    fetchServices();
  }, []);

  if (loading) {
    return <div className="spinner-border" role="status" />;
  }

  return (
    <div className="row">
      {services.map((service) => (
        <div className="col-md-6" key={service.id}>
          <ServiceCard
            title={service.title}
            image={service.image}
            description={service.description}
            contact={service.contact}
          />
        </div>
      ))}
    </div>
  );
}

function App() {
  return (
    <div className="container">
      <h1>Local Services</h1>
      <ServiceList />
    </div>
  );
}

export default App;

ReactDOM.render(
  <Navbar />,
  document.getElementById('navbar')
);
