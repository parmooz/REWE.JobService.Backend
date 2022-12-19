// See https://aka.ms/new-console-template for more information


using System.Net;
using System;
using System.Text;
using REWE.JobService.Api.Contracts;
using System.Text.Json;
using REWE.JobService.Domain.Common;

var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("http://localhost:5000/");

//Step 1 Authentricate
var loginRequest = new LoginRequest("14c1412d-4063-4b37-b4ac-fd7fd8e64bd1", "61435077-b128-40d6-9784-1248e0ea72bd");
StringContent loginContent = new StringContent(JsonSerializer.Serialize(loginRequest), Encoding.UTF8, "application/json");

var loginResult = await httpClient.PostAsync("api/Auth/token", loginContent);
loginResult.EnsureSuccessStatusCode();
var loginStream = await loginResult.Content.ReadAsStreamAsync();
var loginResponse = await JsonSerializer.DeserializeAsync<LoginResponse>(loginStream);


// setp 2  Show filter to applicant

var filtersRequest = new FiltersRequest(loginResponse.authCode);
StringContent filterContent = new StringContent(JsonSerializer.Serialize(filtersRequest), Encoding.UTF8, "application/json");

var filterResult = await httpClient.PostAsync("api/Jobs/search/filters", filterContent);
filterResult.EnsureSuccessStatusCode();
var filterStream = await filterResult.Content.ReadAsStreamAsync();
var filterResponse = await JsonSerializer.DeserializeAsync<FiltersResponse>(filterStream);

// setp 3  Search Job Based On filters

var searchRequest = new JobSearchRequest();
searchRequest.Token = loginResponse.authCode;
StringContent searchContent = new StringContent(JsonSerializer.Serialize(searchRequest), Encoding.UTF8, "application/json");

var searchResult = await httpClient.PostAsync("api/Jobs/search", searchContent);
searchResult.EnsureSuccessStatusCode();
var searchStream = await searchResult.Content.ReadAsStreamAsync();
var searchResponse = await JsonSerializer.DeserializeAsync<JobSearchResponse>(searchStream);

// step 4 show jobDetail
// setp 5  Create One application

var searchRequest = new JobSearchRequest();
searchRequest.Token = loginResponse.authCode;
StringContent searchContent = new StringContent(JsonSerializer.Serialize(searchRequest), Encoding.UTF8, "application/json");

var searchResult = await httpClient.PostAsync("api/job-applications/credentials", searchContent);
searchResult.EnsureSuccessStatusCode();
var searchStream = await searchResult.Content.ReadAsStreamAsync();
var searchResponse = await JsonSerializer.DeserializeAsync<JobSearchResponse>(searchStream);


// setp 6 Get  applicant

// setp 7 submit  applicant Request



Console.WriteLine("");



