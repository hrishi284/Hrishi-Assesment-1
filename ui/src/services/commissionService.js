const API_BASE_URL = "http://localhost:5111";

export const calculateCommission = async (requestData) => {
  const response = await fetch(`${API_BASE_URL}/Commision`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json"
    },
    body: JSON.stringify(requestData)
  });

  if (!response.ok) {
    const errorText = await response.text();
    throw new Error(errorText || "API request failed");
  }

  return response.json();
};