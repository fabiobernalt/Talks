import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";

const ShowConventions = () => {
  const [conventions, setConventions] = useState([
    {
      id: 11,
      title: "this is a title 1",
      description: "this is a description 1",
      numberOfTalks: 0,
      numberOfParticipants: 0,
      location: "this is a location 1",
    },
    {
      id: 12,
      title: "this is a title 2",
      description: "this is a description 2",
      numberOfTalks: 0,
      numberOfParticipants: 0,
      location: "this is a location 2",
    },
    {
      id: 13,
      title: "this is a title 3",
      description: "this is a description 3",
      numberOfTalks: 0,
      numberOfParticipants: 0,
      location: "this is a location 3",
    },
    {
      id: 14,
      title: "this is a title 4",
      description: "this is a description 4",
      numberOfTalks: 0,
      numberOfParticipants: 0,
      location: "this is a location 4",
    },
  ]);

  useEffect(() => {
    fetch("https://localhost:44305/api/convention")
      .then((res) => res.json())
      .then((json) => {
        console.log(json);
        var items = json.items;

        setConventions([...conventions, ...items]);
      });
  }, []);

  return (
    <div>
      {conventions.map((convention, index) => (
        <Link
          key={convention.id}
          to={{
            pathname: `/conventions/${convention.id}`,
          }}
        >
          <div>
            <h3>{convention.title}</h3>
            <p>{convention.description}</p>
            <p>{convention.location}</p>
          </div>
        </Link>
      ))}
    </div>
  );
};

export default ShowConventions;
