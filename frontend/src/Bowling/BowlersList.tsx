import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlersList() {
  const [bowlerData, setBowlers] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlers = async () => {
      const response = await fetch('http://localhost:5083/api/bowling'); // Update with your actual API endpoint
      const data: Bowler[] = await response.json();
      setBowlers(data);
    };

    fetchBowlers();
  }, []);

  return (
    <>
      <h3>Bowlers</h3>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((b) => (
            <tr key={b.bowlerId}>
              <td>{`${b.bowlerFirstName} ${b.bowlerMiddleInit ?? ''} ${b.bowlerLastName}`}</td>
              <td>{b.team?.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlersList;
