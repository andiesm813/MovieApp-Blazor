using System.Net.Http.Json;

namespace Movie_App_v2_FINAL.MovieApp
{
    public class MovieAppService
    {
        private readonly HttpClient http;

        public MovieAppService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<NowPlayingType[]?> GetNowPlaying()
        {
            return await this.http.GetFromJsonAsync<NowPlayingType[]>("https://excel2json.io/api/share/15755be7-cee3-4b74-4382-08da496bf5f2");
        }

        public async Task<MovieListType[]?> GetMovieList()
        {
            return await this.http.GetFromJsonAsync<MovieListType[]>("https://excel2json.io/api/share/99cd7568-0b49-4c09-4387-08da496bf5f2");
        }

        public async Task<TheatresType[]?> GetTheatres()
        {
            return await this.http.GetFromJsonAsync<TheatresType[]>("https://excel2json.io/api/share/5435e256-3846-4895-4385-08da496bf5f2");
        }

        public async Task<ShowtimesType[]?> GetShowtimes()
        {
            return await this.http.GetFromJsonAsync<ShowtimesType[]>("https://excel2json.io/api/share/f179620a-3bb6-49cd-4384-08da496bf5f2");
        }

        public async Task<TheatresNearYouType[]?> GetTheatresNearYou()
        {
            return await this.http.GetFromJsonAsync<TheatresNearYouType[]>("https://excel2json.io/api/share/49f543dc-9c4e-43e8-4386-08da496bf5f2");
        }

        public async Task<MyPurchasesType[]?> GetMyPurchases()
        {
            return await this.http.GetFromJsonAsync<MyPurchasesType[]>("https://excel2json.io/api/share/3f89384c-e58f-429a-4388-08da496bf5f2");
        }
    }
}